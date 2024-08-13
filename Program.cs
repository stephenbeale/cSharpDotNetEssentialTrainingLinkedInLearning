using System;
using System.Linq.Expressions;

bool exit = false;

do 
{
    string input = Console.ReadLine();
    DateTime result = default;

    if (input.IndexOf("exit", StringComparison.OrdinalIgnoreCase) >= 0)
    {
        Console.WriteLine("Invalid date input, exiting");
        exit = true;
    }
    if (DateTime.TryParse(input, out result))
    {
        Console.WriteLine(result);
        bool past = DateTime.Now > result ? true : false;
        TimeSpan interval;
        DateTime.Compare(result, DateTime.Today);

        if (past)
        {
            interval = DateTime.Now - result;
            Console.WriteLine($"{interval.Days} days have passed since that date.");
        }
        if (result == DateTime.Today)
        {
            Console.WriteLine("That date is today!");
        }
        else
        {
            interval = result - DateTime.Now;
            Console.WriteLine($"{interval.Days} days until that date.");
        }
    }    
    else
    {
        Console.WriteLine("Invalid date input, exiting");
    }
    Console.WriteLine("Which date? (or 'exit')");
}
while (!exit)





    


