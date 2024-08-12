string str0 = String.Empty;
Console.WriteLine(str0);
Console.WriteLine(String.IsNullOrEmpty(str0));
string str1 = str0 + "hello there";
Console.WriteLine(str1);
string str2 = String.Join("++", str1);
Console.WriteLine(str2);
