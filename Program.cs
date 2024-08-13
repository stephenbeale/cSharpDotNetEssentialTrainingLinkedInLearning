//DateTime.Now to get current Dt
using System.Globalization;

//Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

//Short date
Console.WriteLine($"{AprFools:d}");

//Full date
Console.WriteLine($"{AprFools:D}");