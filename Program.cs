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

//Contains

Console.WriteLine($"{teststr.Contains("fox")}");
Console.WriteLine($"{teststr.Contains("fox", StringComparison.CurrentCultureIgnoreCase)}");

//StartsWith and EndsWith
Console.WriteLine($"{teststr.StartsWith("the")}");
Console.WriteLine($"{teststr.StartsWith("the")}", StringComparison.CurrentCultureIgnoreCase);
Console.WriteLine($"{teststr.EndsWith("dog")}", StringComparison.CurrentCultureIgnoreCase);

//IndexOf, LastIndexOf
