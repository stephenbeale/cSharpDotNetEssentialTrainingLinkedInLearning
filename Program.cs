using System.Diagnostics;
using System.Text.RegularExpressions;

const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

//Use a stopwach to show elapsed time
Stopwatch sw;

//Use a timeout value when executing RegEx to guard against bad input

//Run the expression and output the result

try
{
	sw = Stopwatch.StartNew();
	Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None);
	MatchCollection mc = CapWords.Matches(thestr);
	sw.Stop();
	Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed} time.");

	foreach (Match match in mc)
	{
		Console.WriteLine($"'{match.Value}' found at position {match.Index}");
	}
}
catch (Exception e)
{
	Console.WriteLine(e.Message);
}