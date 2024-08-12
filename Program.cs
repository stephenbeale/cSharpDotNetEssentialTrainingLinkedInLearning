string str1 = "The quick brown fox";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = { "one", "two", "three", "four" };

//Length of a string
//Console.WriteLine(str1.Length);

////Access individual characters
//Console.WriteLine(str1[14]);

////Iterate over a string
//foreach (char ch in str1)
//{
//    Console.Write(ch);
//	if (ch == 'b')
//	{
//		Console.WriteLine();
//		break;
//	}
//}

//String concatenation
//string outstr;
//outstr = String.Concat(strs);


////Joining strings together
//outstr = String.Join('.', strs);
//Console.WriteLine(outstr);
//outstr = String.Join("---", strs);
//Console.WriteLine(outstr);

//String comparison
//bool isEqual = str2.Equals(str3);
//Console.WriteLine($"{isEqual}");

////Compare function
///*
// * < 0: 1st string is BEFORE 2nd in sort order
// *   0: same position in sort order
// * > 0: 1st string is AFTER 2nd in sort order
// */
//int result = String.Compare(str2, "This is a string");
//Console.WriteLine($"{result}");

//Replacing content

string outstr = str1.Replace("fox", "cat");
Console.WriteLine($"{outstr}");