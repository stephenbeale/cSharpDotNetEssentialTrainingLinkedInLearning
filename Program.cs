//Look in a given directory

using System.Linq.Expressions;

const string chaFilDir = "StevesDirectory";
const string rootDirPath = "W:\\cSharpDotNetEssentialTrainingLinkedInLearning";
const string wordExt = ".doc";
const string excelExt = ".xlsx";
const string pptExt = ".ppt";

string basePath = Directory.GetCurrentDirectory();

string fullPath = Path.Combine(rootDirPath, chaFilDir);

Directory.CreateDirectory(fullPath);

//Analyse file contents

//Print out
try
{
    if (Directory.Exists(fullPath))
    {
        var files = Directory.GetFiles(fullPath);                

        int wordFileCount = 0;
        int excelFileCount = 0;
        int powerpointFileCount = 0;         

        long wordFileSize = 0;
        long excelFileSize = 0;
        long powerpointFileSize = 0;
        long dirFileSize = 0;

        foreach (string file in files)
        {
            FileInfo fileInfo = new FileInfo(file);
            long fileSize = fileInfo.Length;

            string fileExtension = Path.GetExtension(file).ToLower();

            if (fileExtension.Contains(wordExt))
            {
                wordFileCount++;
                wordFileSize += fileSize;
            }               
            else if (fileExtension.Contains(excelExt))
            {
                excelFileCount++;
                excelFileSize += fileSize;                
            }
            else if (fileExtension.Contains(pptExt))
            {
                powerpointFileCount++;
                powerpointFileSize += fileSize;
            }
            dirFileSize += fileSize;
        }

        Console.WriteLine($"Total files in directory: {files.Length}");
        Console.WriteLine($"Word files: {wordFileCount}");
        Console.WriteLine($"Excel files: {excelFileCount}");
        Console.WriteLine($"PowerPoint files: {powerpointFileCount}");
        Console.WriteLine("-----------");

        Console.WriteLine($"Total File Size in directory: {dirFileSize}");
        Console.WriteLine($"Total File Size of Word files:' {wordFileSize}");
        Console.WriteLine($"Total File Size of Excel files: {excelFileSize}");
        Console.WriteLine($"Total File Size of PowerPoint files: {powerpointFileSize}");
    }
}

catch (Exception e)
{
    Console.WriteLine($"Exception caught: {e.Message}");
}