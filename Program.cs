using System.Net;

int[] quarters = { 1, 2, 3, 4 };
int[] sales = { 10000, 150000, 20000, 2250000 };
double[] intlMixPct = { .386, .413, .421, .457 };
int val1 = 1234;
decimal val2 = 1234.5678m;

//Specifying numerical formatting
/*
 * N = number
 * D = decimal
 * F = float
 * G = general
 * etc
 */
//Console.WriteLine($"{val1:D}, {val1:N}, {val1:F}, {val1:G}");
//Console.WriteLine($"{val2:E}, {val2:N}, {val2:F}, {val2:G}");

//Add number after to specify precision
//D6 = decimal with 6 digits of precision
Console.WriteLine($"{val1:D6}, {val1:N2}, {val1:F1}, {val1:G3}");


Console.WriteLine($"Sales by quarter:");
//Specify 12 spaces
Console.WriteLine($"{quarters[0], 12} {quarters[1],12} {quarters[2],12} {quarters[3],12} ");

//Specify 12 spaces BUT currency
Console.WriteLine($"{sales[0], 12:C0} {sales[1],12:C0} {sales[2],12:C0} {sales[3],12:C0} ");

//Specify
Console.WriteLine("International sales:");
Console.WriteLine($"{intlMixPct[0], 12:P0} {intlMixPct[1],12:P0} {intlMixPct[2],12:P1} {intlMixPct[3],12:P2} ");





