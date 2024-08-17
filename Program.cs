//Look in a given directory

var folder = "StevesDirectory";
var resultsFile = "results.txt";

//Variables to ohld results
long XLSCount = 0, DOCCount = 0, PPTCount = 0;
long XLSSize = 0, DOCSize = 0, PPTSize = 0;
long totalFiles = 0, totalSize = 0;


bool IsOfficeFile(string fileName)
{
    if(fileName.EndsWith(".xlsx") || fileName.EndsWith(".docx") || fileName.EndsWith(".pptx"))
    {
        return true;
    }
    return false;
}

try
{
    //DI for given folder
    DirectoryInfo di = new DirectoryInfo(folder);

    foreach (FileInfo fi in di.EnumerateFiles())
    {
        if (IsOfficeFile(fi.Name))
        {
            totalFiles++;
            totalSize += fi.Length;
            if (fi.Name.EndsWith(".xlsx"))
            {
                XLSCount++;
                XLSSize += fi.Length;
            }
            if (fi.Name.EndsWith("docx"))
            {
                DOCCount++;
                DOCSize += fi.Length;
            }
            if (fi.Name.EndsWith("pptx"))
            {
                PPTCount++;
                PPTSize += fi.Length;
            }
        }
    }

    //Output results

    using (StreamWriter sw = File.CreateText(resultsFile))
    {
        sw.WriteLine("===== Results =======");
        sw.WriteLine($"Total files: {totalFiles}");
        sw.WriteLine($"Excel Count: {XLSCount}"); 
        sw.WriteLine($"Word Count: {DOCCount}"); 
        sw.WriteLine($"PPT Count: {PPTCount}\n"); 
        sw.WriteLine($"Total size: {totalSize:N0}"); 
        sw.WriteLine($"Excel size: {XLSSize:N0}"); 
        sw.WriteLine($"Word size: {DOCSize:N0}");
        sw.WriteLine($"PPT size: {PPTSize:N0}");
    }

}
//Analyse file contents

//Print out


catch (Exception e)
{
    Console.WriteLine($"Exception caught: {e.Message}");
}