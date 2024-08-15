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

//try
//{
//	FileInfo fi = new FileInfo(filename);
//	Console.WriteLine($"File length: {fi.Length}");
//    Console.WriteLine($"File directory: {fi.Directory}"); 
//	Console.WriteLine($"File is read-only: {fi.IsReadOnly}");
//}
//catch (Exception e)
//{
//	Console.WriteLine(e.Message);
//}

//Manipulate file information

DateTime dt = new DateTime(2020, 7, 1);
File.SetCreationTime(filename, dt);

Console.WriteLine($"File's new creation time: {File.GetCreationTime(filename)}");

//Mine
File.SetLastAccessTime(filename, (new DateTime(2020, 1, 12, 19, 45, 03)));
Console.WriteLine($"File's new last access time: {File.GetLastAccessTime(filename)}");

//Should copy?
const string filename2 = "myCopiedFile.txt";
File.Copy(filename, filename2);

Console.WriteLine($"Creation time of {filename2}: {File.GetCreationTime(filename2)}");

Console.WriteLine("Moving a file");
File.Move(filename, "movedFile.txt");

File.SetCreationTime(filename2, (new DateTime(1787, 9, 23, 15, 04, 42, 38)));
Console.WriteLine($"Modified creation time for {filename2}: {File.GetCreationTime(filename2)}");

