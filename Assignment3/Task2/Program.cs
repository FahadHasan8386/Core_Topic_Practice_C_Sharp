using System;
using System.IO;

class Program
{
    static void Main()
    {
        // One split file size = 100 MB
        var splitFileSize = 100L * 1024 * 1024;

        // Normal buffer size for file reading
        var readWriteBuffer = new byte[8192];

        // Current project folder
        var projectDirectory = Directory.GetCurrentDirectory();

        // Solution directory (where .sln file exists)
        var solutionDirectory =
            Directory.GetParent(projectDirectory).Parent.Parent.FullName;

        // Large file created in Task-1 (beside .sln)
        var largeFilePath = Path.Combine(solutionDirectory, "LargeRandomFile.txt");

        if (!File.Exists(largeFilePath))
        {
            Console.WriteLine("Large file not found in solution folder.");
            return;
        }

        Console.WriteLine("File splitting started...");

        using (var largeFileStream =
               new FileStream(largeFilePath, FileMode.Open, FileAccess.Read))
        {
            var splitFileCount = 1;
            var folderCount = 1;

            while (largeFileStream.Position < largeFileStream.Length)
            {
                // Create a new folder after every 10 split files
                if ((splitFileCount - 1) % 10 == 0)
                {
                    var newFolderPath =
                        Path.Combine(projectDirectory, "Folder" + folderCount);

                    Directory.CreateDirectory(newFolderPath);
                    folderCount++;
                }

                var currentFolderPath =
                    Path.Combine(projectDirectory, "Folder" + (folderCount - 1));

                var splitFilePath =
                    Path.Combine(currentFolderPath, "Part" + splitFileCount + ".txt");

                using (var splitFileStream =
                       new FileStream(splitFilePath, FileMode.Create, FileAccess.Write))
                {
                    var totalWrittenBytes = 0L;

                    // Write data until 100 MB or end of file
                    while (totalWrittenBytes < splitFileSize &&
                           largeFileStream.Position < largeFileStream.Length)
                    {
                        var bytesRead =
                            largeFileStream.Read(readWriteBuffer, 0, readWriteBuffer.Length);

                        splitFileStream.Write(readWriteBuffer, 0, bytesRead);
                        totalWrittenBytes += bytesRead;
                    }
                }

                splitFileCount++;
            }
        }

        Console.WriteLine("File splitting completed successfully.");
    }
}
