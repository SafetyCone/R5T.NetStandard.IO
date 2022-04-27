using System;
using System.IO;

using Microsoft.Extensions.Logging;

using R5T.NetStandard.IO.Paths;

using R5T.T0064;


namespace R5T.NetStandard.IO
{
    [ServiceImplementationMarker]
    public class FileServicesProvider : IFileServicesProvider, IServiceImplementation
    {
        private ILogger Logger { get; }


        public FileServicesProvider(ILogger<FileServicesProvider> logger)
        {
            this.Logger = logger;
        }

        public void Delete(FilePath filePath)
        {
            this.Logger.LogDebug($"Deleting file:\n{filePath}");

            File.Delete(filePath.Value);

            this.Logger.LogInformation($"Deleted file:\n{filePath}");
        }

        public void Move(FilePath sourceFilePath, FilePath destinationFilePath)
        {
            this.Logger.LogDebug($"Moving file:\n{sourceFilePath} to:\n{destinationFilePath}");

            File.Move(sourceFilePath.Value, destinationFilePath.Value);

            this.Logger.LogInformation($"Moved file:\n{sourceFilePath} to:\n{destinationFilePath}");
        }

        public void WriteAllLines(FilePath filePath, string[] lines)
        {
            this.Logger.LogDebug($"Writing lines to:\n{filePath}");

            File.WriteAllLines(filePath.Value, lines);

            this.Logger.LogInformation($"Wrote lines to:\n{filePath}");
        }

        public void WriteAllText(FilePath filePath, string content)
        {
            this.Logger.LogDebug($"Writing content to:\n{filePath}");

            File.WriteAllText(filePath.Value, content);

            this.Logger.LogInformation($"Wrote content to:\n{filePath}");
        }
    }
}
