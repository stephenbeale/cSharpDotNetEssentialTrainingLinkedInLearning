using System;
using System.Linq.Expressions;

bool exit = false;

do
{
    Console.WriteLine("Which date? (or 'exit')");
    
    string input = Console.ReadLine();

    if(String.IsNullOrEmpty(input))
    {
        Console.WriteLine("Please enter a valid input.");
        continue;
    }
    
    if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("Exiting");
        break;
    }
    if (DateTime.TryParse(input, out DateTime result))
    {
        Console.WriteLine(result);        
        TimeSpan interval = result.Date - DateTime.Today;

        if (interval.Days < 0)
        {
            interval = DateTime.Now - result;
            Console.WriteLine($"That date went by {interval.Days} ago!");
        }
        else if (interval.Days == 0)
        {
            Console.WriteLine("That date is today!");            
        }
        else
        {
            Console.WriteLine($"That date is {interval.Days} days away!");
        }
    }
    else
    {
        
    }    
}
while (!exit);