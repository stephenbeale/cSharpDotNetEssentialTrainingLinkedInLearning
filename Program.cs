using System;
using System.Linq.Expressions;

bool exit = false;

do
{
    Console.WriteLine("Which date? (or 'exit')");
    string input = Console.ReadLine();

    if (input.IndexOf("exit", StringComparison.OrdinalIgnoreCase) >= 0)
    {
        Console.WriteLine("Exiting");
        exit = true;
        break;
    }
    if (DateTime.TryParse(input, out DateTime result))
    {
        Console.WriteLine(result);        
        bool past = DateTime.Now > result ? true : false;
        TimeSpan interval = default;
        int daysBetween = DateTime.Compare(result, DateTime.Today);        

        if (past)
        {
            interval = DateTime.Now - result;
            Console.WriteLine($"That date went by {interval.Days} ago!");
            continue;
        }
        if (result == DateTime.Today)
        {
            Console.WriteLine("That date is today!");
            continue;
        }
        else if(!past)
        {
            interval = result - DateTime.Now;
            Console.WriteLine($"That date is {interval.Days} days away!");
            continue;
        }
    }
    else
    {
        Console.WriteLine("Invalid date input, exiting");
    }    
}
while (!exit);





    


