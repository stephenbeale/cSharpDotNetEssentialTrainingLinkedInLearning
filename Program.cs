//Working with directories

//Create directory if it doesn't exist

const string dir = "StevesDirectory";

string basepath = "W:\\cSharpDotNetEssentialTrainingLinkedInLearning\\";

string fullPath = Path.Combine(basepath, dir);

Console.WriteLine(fullPath);

if (!Directory.Exists(dir))
{
    Console.WriteLine(basepath);
    Console.WriteLine($"Create directory with name: {dir} on path {fullPath}");
    Directory.CreateDirectory(dir);
    //Directory.CreateDirectory(fullPath);
}
else
{
    Directory.Delete(dir);
}

//Get path for current directory
Console.WriteLine(Path.GetDirectoryName(dir));

//Get info about a directory
try
{
    Console.WriteLine($"Directory files: {Directory.GetFileSystemEntries(basepath)}");    
    Console.WriteLine($"Directory parent of {dir}: {Directory.GetParent(dir)}");
    Console.WriteLine($"Directory creation time of {dir} : {Directory.GetCreationTime(dir)}");
    Console.WriteLine($"Directory root of {dir} : {Directory.GetDirectoryRoot(dir)}");
    Console.WriteLine($"\nDirectory files in base path of {basepath}: \n");
    string[] files = Directory.GetFiles(basepath);    
    foreach (var file in files)
    {
        Console.WriteLine($"{file}");        
        Console.WriteLine($"Path file name: {Path.GetFileName(file)}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}


//Enumerate contents of directories

//
//Creating and deleting directories

