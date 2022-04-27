using System;
using System.IO;

using Microsoft.Extensions.Logging;

using R5T.NetStandard.IO.Paths;

using R5T.T0064;


namespace R5T.NetStandard.IO
{
    [ServiceImplementationMarker]
    public class DirectoryServicesProvider : IDirectoryServicesProvider, IServiceImplementation
    {
        private ILogger Logger { get; }


        public DirectoryServicesProvider(ILogger<DirectoryServicesProvider> logger)
        {
            this.Logger = logger;
        }

        public void CreateDirectory(DirectoryPath directoryPath)
        {
            this.Logger.LogDebug($"Creating directory:\n{directoryPath}");

            Directory.CreateDirectory(directoryPath.Value);

            this.Logger.LogInformation($"Created directory:\n{directoryPath}");
        }

        public bool DirectoryExists(DirectoryPath directoryPath)
        {
            var exists = Directory.Exists(directoryPath.Value);
            return exists;
        }
    }
}
