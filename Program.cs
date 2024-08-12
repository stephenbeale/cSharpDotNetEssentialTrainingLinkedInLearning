// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Declare some data types with values

int a = 1;
char c = 'A';
float f = 123.45f;
decimal d = 400.85m;
int b = default;
bool tf = default;

//Console.WriteLine($"{a}, {b},{tf},{c},{f},{d}");
//Console.WriteLine($"{c + a}");
//Console.WriteLine($"{(char)(c + a)}");
//Console.WriteLine($"{f + a}");
//Console.WriteLine($"{f + c}");


S s1;
s1.a = 5;
s1.b = false;

//Perform an operation on a struct
void StructOp(S theStruct)
{
    theStruct.a = 10;
    theStruct.b = true;
    Console.WriteLine($"{theStruct.a}, {theStruct.b}");
}

//Struct = value type

Console.WriteLine("Structs are passed by copy since they are value types:");
Console.WriteLine($"{s1.a}, {s1.b}");
StructOp(s1);
Console.WriteLine($"{s1.a}, {s1.b}");

//Class = reference object

//Class

MyClass cl = new MyClass {a = 5, b = false };

void ClassOp(MyClass theClass)
{
    theClass.a = 10;
    theClass.b = true;
    Console.WriteLine($"{theClass.a}, {theClass.b}");
}


class MyClass {
    public int a;
    public bool b;
};

struct S
{
    public int a;
    public bool b;
}

