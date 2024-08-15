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
    Directory.CreateDirectory(fullPath);
}

//Get path for current directory

//Get info about a directory

//Enumerate contents of directories

//
//Creating and deleting directories

