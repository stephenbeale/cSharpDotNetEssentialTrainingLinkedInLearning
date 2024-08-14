//Creating and deleting files

const string fileName = "TestFile.txt";

//Create new file - overwrites any existing

using(StreamWriter sw = new StreamWriter(fileName))
{
    sw.WriteLine("This is a text file.");
}

//Creates a file if it exist, deletes it otherwise

Console.WriteLine(File.Exists(fileName));

if(File.Exists(fileName))
{
    File.Delete(fileName);
}
else
{
    using(StreamWriter sw = File.CreateText(fileName))
    {
        sw.WriteLine("This is a text file.");
    }
}

Console.WriteLine(File.Exists(fileName));