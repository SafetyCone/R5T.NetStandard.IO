using System;

using R5T.NetStandard.IO.Paths;

using R5T.T0064;


namespace R5T.NetStandard.IO
{
    [ServiceDefinitionMarker]
    public interface IDirectoryServicesProvider : IServiceDefinition
    {
        void CreateDirectory(DirectoryPath directoryPath);
        bool DirectoryExists(DirectoryPath directoryPath);
    }
}
