//Replacements with Regex

using System.Text.RegularExpressions;

string teststr1 = "The quick brown Fox jumps over the lazy Dog";

Regex CapWords = new Regex(@"[A-Z]\w+");

//Replace string contents
string result = CapWords.Replace(teststr1, "***");
Console.WriteLine(teststr1);
Console.WriteLine(result);

//Function to generate replacement text on the fly according to logic - using a delegate
//function takes match object as an argument, returns a string as a result
string MakeUpper(Match m)
{
    string s = m.ToString();
    return s.ToUpper();
}


