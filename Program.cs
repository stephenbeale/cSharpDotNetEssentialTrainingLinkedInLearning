//Look in a given directory

using System.Linq.Expressions;

const string chaFilDir = "challengeFilesDir";
const string dirSeparator = "\\";
const string rootDirPath = "W:\\cSharpDotNetEssentialTrainingLinkedInLearning";
const string wordExt = ".doc";
const string excelExt = ".xslx";
const string pptExt = ".ppt";

string basePath = Directory.GetCurrentDirectory();

string fullPath = Path.Combine(rootDirPath, dirSeparator, chaFilDir);

Directory.CreateDirectory(fullPath);

//Analyse file contents

//Print out
try
{
    if (Directory.Exists(fullPath))
    {
        string[] files = Directory.GetFiles(fullPath);
        Console.WriteLine("Results");
        Console.WriteLine($"Total Files: {files.Length}");

        int wordFileCount = 0;
        int excelFileCount = 0;
        int powerpointFileCount = 0;

        List<string> extensions = new List<string>();

        extensions.Add(wordExt);
        extensions.Add(excelExt);
        extensions.Add(pptExt);            

        int wordFileSize = 0;
        int excelFileSize = 0;
        int powerpointFileSize = 0;

        foreach (string file in files)
        {
            if (file.Contains(wordExt))
            {
                
            }
        }
    }
}
catch (Exception e)
{
    Console.WriteLine($"Exception caught: {e.Message}");
}

/*
 * Results
 * with bulleted list of 
 * Total files
 * Excel files: #
 * Word files: #
 * PPT files: #
 * ----
 */

/*
 * Total size of all files
 * Excel size:
 * Word size:
 * PPT size: 
 */

//Should also run for any newly added files
