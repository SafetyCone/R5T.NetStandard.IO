using System;

using R5T.NetStandard.IO.Paths;

using R5T.T0064;


namespace R5T.NetStandard.IO
{
    [ServiceDefinitionMarker]
    public interface IFileServicesProvider : IServiceDefinition
    {
        void Delete(FilePath filePath);

        void Move(FilePath sourceFilePath, FilePath destinationFilePath);

        /// <summary>
        /// Creates a new file at the given file path (overwriting if file already exists at the file path), writes given lines, then closes the file.
        /// </summary>
        void WriteAllLines(FilePath filePath, string[] lines);

        void WriteAllText(FilePath filePath, string content);
    }
}
