//Look in a given directory

using System.ComponentModel.Design;
using System.Linq.Expressions;

const string chaFilDir = "StevesDirectory";
const string rootDirPath = "W:\\cSharpDotNetEssentialTrainingLinkedInLearning";
const string wordExt = ".doc";
const string excelExt = ".xlsx";
const string pptExt = ".ppt";
string[] exts = {wordExt, excelExt, pptExt};

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

        foreach (var ext in exts)
        {
            files.Where(file => Path.GetExtension(file).ToLower().Contains(ext));
        }
        
        var wordFiles = files.Where(file => Path.GetExtension(file).ToLower().Contains(wordExt));
        var excelFiles = files.Where(file => Path.GetExtension(file).ToLower().Contains(excelExt));
        var pptFiles = files.Where(file => Path.GetExtension(file).ToLower().Contains(pptExt));

        int wordFileCount = wordFiles.Count();
        int excelFileCount = excelFiles.Count();
        int powerpointFileCount = pptFiles.Count();

        var wordFileSize = wordFiles.Sum(file => new FileInfo(file).Length);
        var excelFileSize = excelFiles.Sum(file => new FileInfo(file).Length);
        var powerpointFileSize = pptFiles.Sum(file => new FileInfo(file).Length);
        var dirFileSize = files.Sum(file => new FileInfo(file).Length);

        //foreach (string file in files)
        //{
        //    FileInfo fileInfo = new FileInfo(file);
        //    long fileSize = fileInfo.Length;

        //    string fileExtension = Path.GetExtension(file).ToLower();

        //    if (fileExtension.Contains(wordExt))
        //    {
        //        wordFileCount++;
        //        wordFileSize += fileSize;
        //    }               
        //    else if (fileExtension.Contains(excelExt))
        //    {
        //        excelFileCount++;
        //        excelFileSize += fileSize;                
        //    }
        //    else if (fileExtension.Contains(pptExt))
        //    {
        //        powerpointFileCount++;
        //        powerpointFileSize += fileSize;
        //    }
        //    dirFileSize += fileSize;
        //}

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