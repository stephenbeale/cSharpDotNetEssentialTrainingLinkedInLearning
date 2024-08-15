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
    Console.WriteLine($"File system entries: for {basepath}\n");
    string[] fileSystemEntries = Directory.GetFileSystemEntries(basepath);
    foreach (string fileSystemEntry in fileSystemEntries)
    {
        Console.WriteLine(fileSystemEntry);
    }    
    Console.WriteLine($"\nDirectory parent of {dir}: {Directory.GetParent(dir)}");
    Console.WriteLine($"Directory creation time of {dir} : {Directory.GetCreationTime(dir)}");
    Console.WriteLine($"Directory root of {dir} : {Directory.GetDirectoryRoot(dir)}");
    Console.WriteLine($"\nDirectory files in base path of {basepath}: \n");
    string[] files = Directory.GetFiles(basepath);    
    foreach (var file in files)
    {
        //Console.WriteLine($"{file}");        
        Console.WriteLine($"Path.GetFileName: {Path.GetFileName(file)}");
    }
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

//From video

DirectoryInfo di = new DirectoryInfo(basepath);
Console.WriteLine($"\n\nUsing Directory Info class and object for {basepath}");
Console.WriteLine($"DI name: {di.Name}");
Console.WriteLine($"DI parent: {di.Parent}");
Console.WriteLine($"DI full name: {di.FullName}");
Console.WriteLine($"DI creation time: {di.CreationTime}");


//Enumerate contents of directories

//
//Creating and deleting directories

