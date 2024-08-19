//Replacements with Regex

using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";

Regex CapWords = new Regex(@"[A-Z]\w+");

//Replace string contents
string result = CapWords.Replace(teststr1, "***");
Console.WriteLine(teststr1);
Console.WriteLine(result);