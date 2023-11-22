#define ENC 

using iText.StyledXmlParser.Exceptions;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Text;

namespace DAABOM
{
    /// <summary>
    /// In accordance with the File Format Specification for .lrb Files
    /// version 1.0.0
    /// </summary>
    internal class ReadWriter
    {
        private const string magic = "3cd86ad1-d5cf-4196-97ab-167545a1efe3";
        private const byte majorVersion = 0x01;
        private const byte minorVersion = 0x00;
        private const byte patch = 0x00;

        private readonly static Encoding enc = Encoding.UTF8;

        private string? workingFilepath;
        private FileInfo? workingFile;

        private bool SelectProject(string projectGUID)
        {
            bool createdProject = false;

            if (Program.workingFolderPath is not null)
            {
                workingFilepath = Path.Combine(Program.workingFolderPath, $"{projectGUID}.lrb");
                createdProject = !File.Exists(workingFilepath);
                workingFile = new(workingFilepath);
            }

            return createdProject;
        }

        internal List<ProjectMetadata> ListProjects()
        {
            if (Program.workingFolderPath is not null)
            {
                List<ProjectMetadata> projectList = new();

                string?[] projectGUIDs = Directory.GetFiles(Program.workingFolderPath, "*.lrb",
                    SearchOption.TopDirectoryOnly)
                    .Select(Path.GetFileNameWithoutExtension)
                    .ToArray();

                foreach (string? GUID in projectGUIDs)
                {
                    if (GUID is not null)
                    {
                        SelectProject(GUID);

                        using FileStream stream = workingFile.OpenRead();
                        using BinaryReader reader = new(stream, enc, false);

                        projectList.Add(ParseProjectHeader(reader, GUID));
                    }
                }

                return projectList;
            }

            else
            {
                throw new NotImplementedException(); // fix
            }
        }

        private static ProjectMetadata ParseProjectHeader(BinaryReader reader, string GUID)
        {
            // Read the header and confirm it is correct
            if (reader.ReadByte() != 0x01) throw new Exception("SOH Wrong"); // make better
            if (ReadString(reader, 0x24) != magic) throw new Exception("Magic Wrong"); // make better
            reader.ReadByte(); // RESERVED: Make decision based on version number
            reader.ReadByte(); // RESERVED: Make decision based on version number
            reader.ReadByte(); // RESERVED: Make decision based on version number
            string projectName = ReadStringNoPadding(reader, 0x18);
            if (ReadString(reader, 0x24) != GUID) throw new Exception($"GUID Wrong"); // make better
            uint fileLength = reader.ReadUInt32();
            // Confirm file length
            byte[] hash = reader.ReadBytes(0x04);
            // Confirm hash
            if (reader.ReadByte() != 0x02) throw new Exception("STX Wrong"); // make better

            // Read project data
            DateTime projectCreationDateTime = DateTime.FromBinary(reader.ReadInt64());
            DateTime projectModificationDateTime = DateTime.FromBinary(reader.ReadInt64());
            reader.ReadBytes(0x82); // Reserved null bytes
            if (reader.ReadByte() != 0x1C) throw new Exception("FS Wrong"); // make better

            return new(GUID, projectName, projectCreationDateTime, projectModificationDateTime);
        }

        internal Project? ParseProject(string projectGUID)
        {
            SelectProject(projectGUID);

            using FileStream stream = workingFile.OpenRead();
            using BinaryReader reader = new(stream, enc, false);

            Project project = new(ParseProjectHeader(reader, projectGUID));

            while (reader.PeekChar() != 0x03) // Check if we are about to read an ETX, if not:
            {
                if (reader.PeekChar() != 0x19) // Check if we are about to read an EM, if not:
                {
                    project.AddComponent(ParseComponentReference(reader));

                    while (reader.ReadByte() != 0x19) ; // Skip bytes until we pass an EM
                }
            }

            if (reader.ReadByte() != 0x03) throw new Exception("ETX Wrong"); // make better
            if (reader.ReadByte() != 0x04) throw new Exception("EOT Wrong"); // make better

            return project;
        }

        internal ComponentReference ParseComponentReference(BinaryReader reader)
        {
            long offset = reader.BaseStream.Position;

            string partNumber = ReadString(reader, 0x09);
            string partRevision = ReadStringNoPadding(reader, 0x04);
            string partTitle = ReadStringNoPadding(reader, 0x18);

            return new(partNumber, partRevision, partTitle, offset);
        }

        internal Component ParseComponent(string projectGUID, ComponentReference reference) // consider making one that parses by offset only, also maybe make static w/ reader as input
        {
            SelectProject(projectGUID);

            using FileStream stream = workingFile.OpenRead();
            using BinaryReader reader = new(stream, enc, false);

            long offset = reference.Offset;
            reader.BaseStream.Seek(offset, SeekOrigin.Begin);

            if (ParseComponentReference(reader) == reference)
            {
                DateTime revisionDateTime = DateTime.FromBinary(reader.ReadInt64());
                char status = (char)reader.ReadByte();
                string description = ReadStringNoPadding(reader, 0x18);
                char origin = (char)reader.ReadByte();
                string vendorPN = ReadStringNoPadding(reader, 0x18);
                string material = ReadStringNoPadding(reader, 0x18);
                string notes = ReadStringNoPadding(reader, 0x1A4);
                uint nextRevOffset = reader.ReadUInt32();
                uint prevRevOffset = reader.ReadUInt32();

                throw new NotFiniteNumberException(); // fix
            }

            else
            {
                throw new NotImplementedException(); // fix
            }
        }

        internal Project? CreateProject(string projectName)
        {
            string projectGUID = Guid.NewGuid().ToString();
            DateTime now = DateTime.Now;
            long nowBytes = now.ToBinary();

            if (SelectProject(projectGUID) && workingFile is not null)
            {
                using FileStream stream = workingFile.OpenWrite();
                using BinaryWriter writer = new(stream, enc, false);

                writer.Write((byte)0x01);
                writer.Write(ByteFormatString(magic, 0x24));
                writer.Write(majorVersion);
                writer.Write(minorVersion);
                writer.Write(patch);
                writer.Write(ByteFormatString(projectName, 0x18));
                writer.Write(ByteFormatString(projectGUID, 0x24));
                writer.Write(new byte[0x04]); // Fix: make this actually do what it's supposed to
                writer.Write(new byte[0x04]); // Fix: make this actually do what it's supposed to
                writer.Write((byte)0x02);

                writer.Write(nowBytes);
                writer.Write(nowBytes);
                writer.Write(new byte[0x82]); // Reserved null bytes
                writer.Write((byte)0x1C);

                writer.Write((byte)0x03);
                writer.Write((byte)0x04);

                return new(new(projectGUID, projectName, now, now));
            }

            else
            {
                throw new Exception("Error while creating project"); // make better
            }
        }

        private static string ReadString(BinaryReader reader, int length) =>
            enc.GetString(reader.ReadBytes(length));

        private static string ReadStringNoPadding(BinaryReader reader, int length) =>
            ReadString(reader, length).TrimEnd('\0');

        private static byte[] ByteFormatString(string inputString, int stringLength)
        {
            string properLengthString;

            if (inputString.Length < stringLength)
            {
                properLengthString = inputString.PadRight(stringLength, '\0');
            }

            else if (inputString.Length > stringLength)
            {
                properLengthString = inputString[..stringLength];
            }

            else
            {
                properLengthString = inputString;
            }

            return enc.GetBytes(properLengthString);
        }
    }
}