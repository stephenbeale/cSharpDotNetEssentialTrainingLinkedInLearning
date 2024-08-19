//Transpose a date string using regex

using System.Text.RegularExpressions;

Regex DateFormatter = Regex(@"[A-z]");

//Take date string input

Console.WriteLine("Input a date in the format dd-mm-yyyy or d-m-yy");
string dateInput = Console.ReadLine();

DateTime dt = new DateTime();

if (DateTime.TryParse(dateInput, out dt))
{
    Console.WriteLine($"Date parsed to: P{dt}");
}
else if (!DateTime.TryParse(dateInput, out dt))
{
    Console.WriteLine("Invalid date, try again.");
}

//Return a date string in format 'yyyy-mm-dd'


/*
 * Validate inputs for
 * day: 1-2 chars max.
 * month: 1-2 chars max.
 * year: 2 or 4 chars only
 * Invalid: return empty string
 */


//Handle timeout

