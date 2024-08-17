//Look in a given directory

var folder = "StevesDirectory";
var resultsFile = "results.txt";

//Variables to ohld results
long XLSCount = 0, DOCCount = 0, PPTCount = 0;
long XLSSize = 0, DOCSize = 0, PPTSize = 0;
long totalFiles = 0, totalSize = 0;


bool isOfficeFile(string fileName)
{
    if(fileName.EndsWith(".xslx") || fileName.EndsWith(".docx") || fileName.EndsWith(".pptx"))
    {
        return true;
    }
    return false;
}



//Analyse file contents

//Print out
try
{

}

catch (Exception e)
{
    Console.WriteLine($"Exception caught: {e.Message}");
}