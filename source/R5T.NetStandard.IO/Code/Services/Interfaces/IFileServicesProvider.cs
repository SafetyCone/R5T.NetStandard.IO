using System;

using R5T.NetStandard.IO.Paths;


namespace R5T.NetStandard.IO
{
    public interface IFileServicesProvider
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
