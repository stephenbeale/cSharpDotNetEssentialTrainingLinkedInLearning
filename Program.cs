using System;

bool exit = false;

while (!exit) {
    {
        Console.WriteLine("Which date? (or 'exit')");

        string? input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
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
            Console.WriteLine($"Parsed Date: {result.ToShortDateString()}");
            TimeSpan interval = result.Date - DateTime.Today;

            if (interval.Days < 0)
            {
                Console.WriteLine($"That date went by {-interval.Days} days ago!");
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
            Console.WriteLine("Invalid date input, please try again.");
        }
    }
    while (!exit) ;
    {
        Console.WriteLine("Which date? (or 'exit')");

        string? input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input))
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
            Console.WriteLine($"Parsed Date: {result.ToShortDateString()}");
            TimeSpan interval = result.Date - DateTime.Today;

            if (interval.Days < 0)
            {
                Console.WriteLine($"That date went by {-interval.Days} days ago!");
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
            Console.WriteLine("Invalid date input, please try again.");
        }
    }
}
