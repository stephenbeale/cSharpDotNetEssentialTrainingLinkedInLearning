//Regex here we come

//Must add this using statement explicitly
using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";
string teststr2 = "the quick brown fox jumps over the lazy dog";

//IsMatch function for content of a string

//Checks if a string has capitals, returns boolean
Regex CapWords = new Regex(@"[A-Z]\w+");

Console.WriteLine(CapWords.IsMatch(teststr1));
Console.WriteLine(CapWords.IsMatch(teststr2));

//Ignore case in searchs

Regex NoCase = new Regex(@"fox", RegexOptions.IgnoreCase);

Console.WriteLine(NoCase.IsMatch(teststr1));
Console.WriteLine(NoCase.IsMatch(teststr2));

//Match - returns one result

Match m = CapWords.Match(teststr1);
Console.WriteLine();
while(m.Success)
{
    Console.WriteLine($"'{m.Value}' found at  position {m.Index}");
    m = m.NextMatch();
}

//Matches = multiple matches

MatchCollection mc = CapWords.Matches(teststr1);
Console.WriteLine($"Found {mc.Count} matches:");

foreach ( Match match in mc)    
{
    Console.WriteLine($"'{match.Value}' found at position {match.Index}");
}