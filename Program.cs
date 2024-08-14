﻿//Reading and writing files

//Make sure example file exists

const string filename = "TestFile.txt"; ;

//1 WriteAllText - overwrites a file with given content
if(!File.Exists(filename))
{
    File.WriteAllText(filename, "This is a text file.");
}

//2 Append text to an existing file - useful for as we go
File.AppendAllText(filename, "This text gets appended to the file.");

//3 FileStream to open, write to file until stream is closed

using (StreamWriter sw = File.AppendText(filename))
{
    sw.WriteLine("\nLine1");
    sw.WriteLine("Line2");
    sw.WriteLine("Line3");
}

//4 

//5 Read all text reads all the content from a file

string content = File.ReadAllText(filename);
Console.WriteLine(content);