using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

    //This is how your code will be called
    //You can edit this code to try different testing cases.

    string[] test_strs =
    {
        "25/5/2030",
        "1/1/80",
		"11/12/2023",
        "Junely 6",
        "12/25/1980",
        "10/15/30",
		"4th July 2024"
    };

	test_strs
		.ToList()
		.ForEach(x => Console.WriteLine(Answer.ReverseDate(x)));
    test_strs
		.ToList()
		.ForEach(x => x.Contains("/"));

    string learnerResult = Answer.ReverseDate(test_strs[0]);
	Console.WriteLine(learnerResult);


public class Answer
{
    public static Boolean ShowExpectedResult = false;
    public static Boolean ShowHints = false;

    static string ReverseDateFormat(string sourceDate)
    {
        const int TIMEOUT = 1000;
		try
		{
			return Regex.Replace(sourceDate, 
				@"^(?<mon>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})$",
				"${year}-${mon}-${day}", RegexOptions.None,
			TimeSpan.FromMilliseconds(TIMEOUT));
		}
		catch (RegexMatchTimeoutException)
		{
			return sourceDate;
		}
    }

	public static string ReverseDate(string inputDate)
	{
		//Make sure it's a valid date before conversion
		DateTime result;
		if(DateTime.TryParse(inputDate, out result))
		{
			string reverseDate = ReverseDateFormat(inputDate);
			return reverseDate;
		}
		else
		{
			return "";
		}
	}	

}