using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.NetStandard.IO
{
    public interface IDirectoryServicesProvider
    {
        void CreateDirectory(DirectoryPath directoryPath);
        bool DirectoryExists(DirectoryPath directoryPath);
    }
}
