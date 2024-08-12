//Parsing numbers from strings

string[] NumStrs = { "  1  ", "  1.45  " , "-100", "5e+04"};

int testInt;
float testFloat;
bool result;

//Parse method - attempts to parse a string to a number
foreach (string str in NumStrs)
{
	try
	{
		testFloat = float.Parse(str);
		Console.WriteLine($"Parsed number is {testFloat}");
        testInt = int.Parse(str);
        Console.WriteLine($"Parsed int is {testInt}");
    }
	catch (FormatException e)
	{
		Console.WriteLine($"Could not parse '{str}': {e.Message}");
	}
}