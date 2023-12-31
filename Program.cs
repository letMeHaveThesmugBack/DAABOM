using DAABOM.Properties;
using Minio;
using Minio.DataModel;
using Minio.DataModel.Result;
using Minio.Exceptions;
using System.Net;
using System.Reflection;

namespace DAABOM
{
    internal static class Program
    {
        internal static string? workingFolderPath;

        internal static IMinioClient client =  new MinioClient();
        internal static string? connectedServer;
        internal static string? username;
        internal static Dictionary<string, Bucket> bucketDictionary = new();
        internal static Bucket? workingBucket = new();
        internal delegate void OnClientClosed();
        internal static event OnClientClosed? onClientClosed;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Welcome());
        }

        internal static async void OpenClient(NetworkCredential credentials, MinioServerDialog callingDialog)
        {
            try
            {
                string[] endpointAndPort = credentials.Domain.Split(':');

                CloseClient();

                client =
                    (
                        endpointAndPort.Length > 1 ?
                        (
                            int.TryParse(endpointAndPort[1], out int port) ?
                                new MinioClient().WithEndpoint(endpointAndPort[0], port)
                            :
                                throw new FormatException("Invalid port.")
                        )
                        :
                            new MinioClient().WithEndpoint(endpointAndPort[0])
                    )
                    .WithCredentials(credentials.UserName, credentials.Password)
                    .WithSSL(true)
                    .Build();

                callingDialog.SetWaitingState(true);

                ListAllMyBucketsResult? bucketList;
                int numberOfBuckets;

                try
                {
                    bucketList = await client.ListBucketsAsync(callingDialog.cancellationTokenSource.Token);
                }
                catch (NullReferenceException)
                {
                    throw new MinioException("An error occurred while attempting to retrieve buckets.");
                }

                try
                {
                    numberOfBuckets = bucketList.Buckets.Count;
                }

                catch
                {
                    throw new BucketNotFoundException("No buckets were found.");
                }

                connectedServer = Settings.Default.MinioServer = credentials.Domain;
                username = Settings.Default.Username = credentials.UserName;

                bucketDictionary.Clear();
                foreach (Bucket bucket in bucketList.Buckets)
                {
                    bucketDictionary.Add(bucket.Name, bucket);
                }

                MessageBox.Show($"Connected Successfully! {numberOfBuckets}{(numberOfBuckets > 1 ? " buckets were found." : 
                    " bucket was found.")}",
                    "Minio Connection Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                callingDialog.Close();
                callingDialog.DialogResult = DialogResult.OK;
            }

            catch (TaskCanceledException) { }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Minio Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CloseClient();
            }

            callingDialog.SetWaitingState(false);
        }

        internal static void CloseClient()
        {
            client.Dispose();
            connectedServer = null;
            username = null;
            bucketDictionary.Clear();
            workingBucket = new();

            onClientClosed?.Invoke();
        }
    }
}