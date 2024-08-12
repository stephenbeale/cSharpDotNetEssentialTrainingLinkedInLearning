// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Declare some data types with values

int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;

Console.WriteLine($"{a}, {b},{tf},{c},{f},{d}");
Console.WriteLine($"{c + a}");
Console.WriteLine($"{(char)(c + a)}");
Console.WriteLine($"{f + a}");
Console.WriteLine($"{f + c}");

//Class

class MyClass {
    public int a;
    public int b;
};

struct S
{
    public int a;
    public bool b;
}

