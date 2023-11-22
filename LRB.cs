using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DAABOM
{
    internal record ProjectMetadata
    {
        internal ProjectMetadata(string guid, string name, DateTime creationDateTime,
        DateTime lastModifiedDateTime)
        {
            GUID = guid;
            Name = name;
            CreationDateTime = creationDateTime;
            LastModifiedDateTime = lastModifiedDateTime;
        }

        internal string GUID { get; init; }
        internal string Name { get; init; }
        internal DateTime CreationDateTime { get; init; }
        internal DateTime LastModifiedDateTime { get; init; }
    }

    internal record ComponentReference
    {
        internal ComponentReference(string partNumber, string revision, string title, long offset)
        {
            PartNumber = partNumber;
            Revision = revision;
            Title = title;
            Offset = offset;
        }

        internal string PartNumber { get; init; }
        internal string Revision { get; init; }
        internal string Title { get; init; }
        internal long Offset { get; init; }
    }

    internal partial record Project
    {
        internal Project(ProjectMetadata metadata)
        {
            Metadata = metadata;
            Components = new();
        }

        internal ProjectMetadata Metadata { get; init; }
        internal SortedList<string, SortedList<string, ComponentReference>> Components { get; private set; }

        [GeneratedRegex(@"^[A-Z]\d{8}/[A-Z]{1,4}$")]
        private static partial Regex descriptorRegex();

        internal void AddComponent(ComponentReference component)
        {
            string partNumber = component.PartNumber;

            if (!Components.ContainsKey(partNumber))
            {
                Components.Add(partNumber, new() { { component.Revision, component } });
            }

            else
            {
                Components[component.PartNumber].Add(component.Revision, component);
            }
        }

        internal ComponentReference? GetComponent(string descriptor)
        {
            if (descriptorRegex().IsMatch(descriptor))
            {
                string[] PNAndRev = descriptor.Split('/');
                return Components[PNAndRev[0]][PNAndRev[1]];
            }

            else
            {
                return null;
            }
        }
    }

    internal record Component
    {
        internal Component(ComponentReference reference, DateTime revisionDateTime,
        char status, string description, char origin, string vendor,
        string vendorPartNumber, string material, string notes, List<ComponentReference> bom,
        List<ComponentReference> whereUsed, FileReferences references)
        {
            Reference = reference;
            RevisionDateTime = revisionDateTime;
            Status = status;
            Description = description;
            Origin = origin;
            Vendor = vendor;
            VendorPartNumber = vendorPartNumber;
            Material = material;
            Notes = notes;
            BOM = bom;
            WhereUsed = whereUsed;
            References = references;
        }

        internal ComponentReference Reference { get; init; }
        internal DateTime RevisionDateTime { get; init; }
        internal char Status { get; init; }
        internal string Description { get; init; }
        internal char Origin { get; init; }
        internal string Vendor { get; init; }
        internal string VendorPartNumber { get; init; }
        internal string Material { get; init; }
        internal string Notes { get; init; }
        internal List<ComponentReference> BOM { get; init; }
        internal List<ComponentReference> WhereUsed { get; init; }
        internal FileReferences References { get; init; }
    }

    internal record FileReferences
    {
        internal FileReferences(string swPartFilename, string swDWGFilename, string dwgPDFFilename,
            List<string> otherReferences)
        {
            SWPartFilename = swPartFilename;
            SWDWGFilename = swDWGFilename;
            DWGPDFFilename = dwgPDFFilename;
            OtherReferences = otherReferences;
        }

        internal string SWPartFilename { get; init; }
        internal string SWDWGFilename { get; init; }
        internal string DWGPDFFilename { get; init; }
        internal List<string> OtherReferences { get; init; }
    }
}