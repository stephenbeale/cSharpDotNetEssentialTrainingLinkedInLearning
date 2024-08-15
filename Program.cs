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

//Get details about the files

//Console.WriteLine(File.GetCreationTime(filename));
//Console.WriteLine(File.GetLastWriteTime(filename)); Console.WriteLine(File.GetLastAccessTime(filename));

//Make file read-only and print attributes
//File.SetAttributes(filename, FileAttributes.ReadOnly);
//Console.WriteLine(File.GetAttributes(filename));

////My playing
//File.SetAttributes(filename, FileAttributes.IntegrityStream);

//Console.WriteLine(File.GetAttributes(filename));


//Get general file info

try
{
	FileInfo fi = new FileInfo(filename);
	Console.WriteLine($"File length: {fi.Length}");
    Console.WriteLine($"File directory: {fi.Directory}"); 
	Console.WriteLine($"File is read-only: {fi.IsReadOnly}");
}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}