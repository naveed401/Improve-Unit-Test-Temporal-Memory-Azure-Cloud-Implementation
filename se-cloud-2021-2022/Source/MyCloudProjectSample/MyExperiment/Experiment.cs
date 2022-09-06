using Azure.Storage.Queues;
using Azure.Storage.Queues.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using MyCloudProject.Common;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;


namespace MyExperiment
{
    /// <summary>
    /// This class implements the ML experiment that will run in the cloud. This is refactored code from my SE project.
    /// </summary>
    public class Experiment : IExperiment
    {
        private IStorageProvider storageProvider;

        private ILogger logger;

        private MyConfig config;

        private ExerimentRequestMessage requestMessage;

        public Experiment(IConfigurationSection configSection, IStorageProvider storageProvider, ILogger log, ExerimentRequestMessage request)
        {
            this.storageProvider = storageProvider;
            this.logger = log;
            this.requestMessage = request;

            config = new MyConfig();
            configSection.Bind(config);
        }

        public Task<ExperimentResult> Run(string inputFile)
        {
            // TODO read file

            // YOU START HERE WITH YOUR SE EXPERIMENT!!!!

            ExperimentResult res = new ExperimentResult(this.config.GroupId, null);

            res.StartTimeUtc = DateTime.UtcNow;

            // Run your experiment code here.

            return Task.FromResult<ExperimentResult>(res); // TODO...
        }



        /// <inheritdoc/>
        public async Task RunQueueListener(CancellationToken cancelToken)
        {
            ExperimentResult res = new ExperimentResult("damir", "123")
            {
                Accuracy = (float)0.5,
            };

            QueueClient queueClient = new QueueClient(this.config.StorageConnectionString, this.config.Queue);
            
            while (cancelToken.IsCancellationRequested == false)
            {
                QueueMessage message = await queueClient.ReceiveMessageAsync();

                if (message != null)
                {
                    try
                    {

                        string msgTxt = Encoding.UTF8.GetString(message.Body.ToArray());

                        this.logger?.LogInformation($"Received the message {msgTxt}");

                        ExerimentRequestMessage request = JsonSerializer.Deserialize<ExerimentRequestMessage>(msgTxt);
                        this.requestMessage = request;

                        var inputFile = await this.storageProvider.DownloadInputFile(request.InputFile);

                        ExperimentResult result = await this.Run(inputFile);

                        //TODO. do serialization of the result.
                        await storageProvider.UploadResultFile("outputfile.txt", null);

                        await storageProvider.UploadExperimentResult(result);

                        await queueClient.DeleteMessageAsync(message.MessageId, message.PopReceipt);
                    }
                    catch (Exception ex)
                    {
                        this.logger?.LogError(ex, "TODO...");
                    }
                }
                else
                {
                    await Task.Delay(500);
                    logger?.LogTrace("Queue empty...");
                }
            }

            this.logger?.LogInformation("Cancel pressed. Exiting the listener loop.");
        }

        #region Private Methods


        #endregion
    }
}
