//DateTime.Now to get current Dt
using System.Globalization;

DateTime now = DateTime.Now;
Console.WriteLine(now);

//DateTime.Today
DateTime today = DateTime.Today;
Console.WriteLine(today);

//DateOnly and TimeOnly
DateOnly dt = DateOnly.FromDateTime(DateTime.Now);
TimeOnly tm = TimeOnly.FromDateTime(now);
Console.WriteLine(dt);
Console.WriteLine(tm);

//Inspecting properties on dates
Console.WriteLine(today.DayOfWeek);
Console.WriteLine(today.DayOfYear);

//Methods on dates to change values
//Can add multiple
Console.WriteLine(
    today
    .AddDays(23.65)
    .AddMonths(12)
    .AddYears(43));

now = now.AddDays(87);
Console.WriteLine(now);
Console.WriteLine(now.ToUniversalTime().ToString());


//See here for format specifier docs and more examples: https://learn.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings#FullDateLongTime
Console.WriteLine("Format specifier: D");
Console.WriteLine(now.ToString("D"));

Console.WriteLine("Format specifier: F");
Console.WriteLine(now.ToString("F", CultureInfo.CreateSpecificCulture("en-CY")));

Console.WriteLine("Format specifier: G");
Console.WriteLine(now.ToString("G", CultureInfo.CreateSpecificCulture("en-CY")));

Console.WriteLine("Format specifier: M");
Console.WriteLine(now.ToString("M"));

Console.WriteLine("Format specifier: o");
Console.WriteLine(now.ToString("o"));

//TimeSpan class for a duration of time
DateTime AprilFools = new DateTime(now.Year, 4, 1);
DateTime NewYears = new DateTime(now.Year, 1, 1);
TimeSpan interval = AprilFools - NewYears;
Console.WriteLine(interval);

//Dates can be compared using regular operators
Console.WriteLine($"{NewYears < AprilFools}");
Console.WriteLine($"{NewYears > AprilFools}");
