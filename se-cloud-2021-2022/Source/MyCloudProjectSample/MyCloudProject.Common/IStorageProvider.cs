using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MyCloudProject.Common
{
    /// <summary>
    /// Defines the contract for all storage operations.
    /// </summary>
    public interface IStorageProvider
    {
        /// <summary>
        /// Downloads the input file for training.
        /// </summary>
        /// <param name="fileName">The name of the local file where the input is downloaded.</param>
        /// <returns>The fullpath name of the file as downloaded locally.</returns>
        Task<string> DownloadInputFile(string fileName);

        /// <summary>
        /// Uploads results of the experiment as the file of the container storage.
        /// </summary>
        /// <param name="fileName">full file path to upload</param>
        /// <param name="data">not used</param>
        /// <returns></returns>
        Task UploadResultFile(string fileName, byte[] data);

        /// <summary>
        /// Uploads results of the experiment as the entity of the table storage.
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        Task UploadExperimentResult(ExperimentResult result);
    }
}
