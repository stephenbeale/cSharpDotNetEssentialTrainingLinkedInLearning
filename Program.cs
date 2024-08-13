//DateTime.Now to get current Dt
using System.Globalization;

//Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

//Short date
Console.WriteLine($"{AprFools:d}");

//Full date
Console.WriteLine($"{AprFools:D}");

Console.WriteLine($"{AprFools:f}");
Console.WriteLine($"{AprFools:F}");

Console.WriteLine($"{AprFools:g}");
Console.WriteLine($"{AprFools:G}");

//Specific culture
Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));
Console.WriteLine(AprFools.ToString("D", CultureInfo.CreateSpecificCulture("de-DE")));


//Trying Welsh culture
Console.WriteLine(AprFools.ToString("d", CultureInfo.CreateSpecificCulture("de-DE")));
Console.WriteLine(AprFools.ToString("D", CultureInfo.CreateSpecificCulture("de-DE")));
