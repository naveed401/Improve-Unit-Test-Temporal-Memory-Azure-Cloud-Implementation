using Azure;
using Azure.Data.Tables;
using Azure.Storage.Blobs;
using Microsoft.Extensions.Configuration;
using MyCloudProject.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MyExperiment
{
    public class AzureStorageProvider : IStorageProvider
    {
        private MyConfig config;

        public AzureStorageProvider(IConfigurationSection configSection)
        {
            config = new MyConfig();
            configSection.Bind(config);
        }

        public async Task<string> DownloadInputFile(string fileName)
        {
            BlobContainerClient container = new BlobContainerClient(this.config.StorageConnectionString, this.config.TrainingContainer);
            await container.CreateIfNotExistsAsync();

            string BasePath = AppDomain.CurrentDomain.BaseDirectory;
            string localFilePath = Path.Combine(BasePath, fileName);
            string downloadFilePath = localFilePath.Replace(".csv", "_downloaded.csv");

            // Get a reference to a blob named "sample-file"
            BlobClient blob = container.GetBlobClient(fileName);

            if (await blob.ExistsAsync())
            {
                // Download the blob's contents and save it to a file
                Console.WriteLine($"Downloading blob to: {downloadFilePath}");
                await blob.DownloadToAsync(downloadFilePath);
                return downloadFilePath;
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        public async Task UploadExperimentResult(ExperimentResult result)
        {
            Console.WriteLine($"Upload ExperimentResult to table: {this.config.ResultTable}");
            var client = new TableClient(this.config.StorageConnectionString, this.config.ResultTable);

            await client.CreateIfNotExistsAsync();

            try
            {
                await client.UpsertEntityAsync<ExperimentResult>(result);
                Console.WriteLine("Uploaded to Table Storage completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to upload to Table Storage: {ex.ToString()}");
            }

        }

        public async Task UploadResultFile(string fileName, byte[] data)
        {
            BlobContainerClient container = new BlobContainerClient(this.config.StorageConnectionString, this.config.TrainingContainer);
            await container.CreateIfNotExistsAsync();

            try
            {
                BlobClient blobClient = container.GetBlobClient(fileName);
                Console.WriteLine($"Uploading to Blob storage as blob:\n\t {blobClient.Uri}\n");
                await blobClient.UploadAsync(fileName, true);
                Console.WriteLine("Uploaded to Blob Storage successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to upload to Blob Storage: {ex.ToString()}");
            }
        }

    }


}
