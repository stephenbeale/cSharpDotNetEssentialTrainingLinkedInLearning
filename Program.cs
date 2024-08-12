//string str0 = String.Empty;
//Console.WriteLine(str0);
//Console.WriteLine(String.IsNullOrEmpty(str0));
//string str1 = str0 + "hello there";
//Console.WriteLine(str1);
//string[] strs = {"my", "word", "what", "an", "array" };
//string str2 = String.Join("++", strs);
//Console.WriteLine(str2);

//Example file for searching string content

string teststr = "The quick brown fox jumps over the lazy Dog";

////Contains
//Console.WriteLine($"{teststr.Contains("fox")}");
//Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

////StartsWith and EndsWith
//Console.WriteLine($"{teststr.StartsWith("the")}");
//Console.WriteLine($"{teststr.StartsWith("the", StringComparison.CurrentCultureIgnoreCase)}");

//Console.WriteLine($"{teststr.EndsWith("dog")}");
//Console.WriteLine($"{teststr.EndsWith("dog", StringComparison.CurrentCultureIgnoreCase)}");

//IndexOf, LastIndexOf
Console.WriteLine($"{teststr.IndexOf("the")}");
//Ignoring case finds capitalised version at start of string, hence position 0 here.
Console.WriteLine($"{teststr.IndexOf("the", 
StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"{teststr.LastIndexOf("the")}");

//Empty, null or whitespace string
string str1 = null;
string str2 = "   ";
string str3 = String.Empty;
Console.WriteLine($"{String.IsNullOrEmpty(str1)}");
Console.WriteLine($"{String.IsNullOrEmpty(str2)}");
Console.WriteLine($"{String.IsNullOrEmpty(str3)}");
Console.WriteLine($"{String.IsNullOrWhiteSpace(str2)}");

Console.WriteLine($"{String.Compare(str3, str2)}");