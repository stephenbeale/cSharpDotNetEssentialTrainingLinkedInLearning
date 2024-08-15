//Working with directories

//Create directory if it doesn't exist

const string dir = "StevesDirectory";

if(!Directory.Exists(dir))
{
    Console.WriteLine($"Create directory with name: {dir}");
    //Directory.CreateDirectory($"{Directory.GetCurrentDirectory}//{dir}");
    Directory.CreateDirectory(dir);
}

//Get path for current directory

//Get info about a directory

//Enumerate contents of directories

//
//Creating and deleting directories

