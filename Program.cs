string str1 = "The quick brown fox";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = { "one", "two", "three", "four" };

//Length of a string
Console.WriteLine(str1.Length);

//Access individual characters
Console.WriteLine(str1[14]);

//Iterate over a string
foreach (char ch in str1)
{
    Console.WriteLine(ch);
	if (ch == 'b')
	{
		Console.WriteLine();
		break;
	}
}

//String concatenation

//Joining strings together