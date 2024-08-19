using System.Text.RegularExpressions;

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