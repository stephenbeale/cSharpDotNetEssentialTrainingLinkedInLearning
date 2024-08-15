//Working with file information

//Make sure the example file exists

const string filename = "TestFile.txt";

if (!File.Exists(filename))
{
    using (StreamWriter sw = File.CreateText(filename))
    {
        sw.WriteLine("This is a text file.");
    }
}