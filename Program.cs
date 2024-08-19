using System.Diagnostics;
using System.Text.RegularExpressions;

const string thestr = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";

//Use a stopwach to show elapsed time
Stopwatch sw;

//Use a timeout value when executing RegEx to guard against bad input
const int MAX_REGEX_TIME = 1;
//1 second timeout added
TimeSpan timeout = TimeSpan.FromMilliseconds(MAX_REGEX_TIME);

//Run the expression and output the result
try
{
	sw = Stopwatch.StartNew();
	//If execution time of regex exceeds max. time I've set, must throw an exception
	Regex CapWords = new Regex(@"(a+a+)+b", RegexOptions.None, timeout);
	MatchCollection mc = CapWords.Matches(thestr);
	sw.Stop();
	Console.WriteLine($"Found {mc.Count} matches in {sw.Elapsed} time.");

	foreach (Match match in mc)
	{
		Console.WriteLine($"'{match.Value}' found at position {match.Index}");
	}
}
catch (RegexMatchTimeoutException e)
{
	Console.WriteLine($"The Regex took too long to execute! {e.Message}");
}