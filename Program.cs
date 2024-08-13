using System;
using System.Linq.Expressions;

Console.WriteLine("Which date? (or 'exit')");

string input = Console.ReadLine();
DateTime result = default;

if (DateTime.TryParse(input, out result))
{
    Console.WriteLine(result);
}
else if(input.IndexOf("exit", StringComparison.OrdinalIgnoreCase) >= 0)
{
    Console.WriteLine("Invalid date input, exiting");
}
else
{
    Console.WriteLine("Invalid date input, exiting");
}
