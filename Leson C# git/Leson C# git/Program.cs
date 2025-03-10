

using System.ComponentModel.Design;

float a1;
float a2;
string s;


Console.WriteLine("Fifst Value");
a1 = float.Parse(Console.ReadLine());
Console.WriteLine("Second Value");
a2 = float.Parse(Console.ReadLine());
Console.WriteLine("char");
s = Console.ReadLine();
if (s == "+")
    Console.WriteLine(a1 + a2);
else if (s == "-")
    Console.WriteLine(a1 - a2);
else if (s == "*") 
Console.WriteLine(a1 * a2);
        else if (s == "/") 
Console.WriteLine(a1 / a2);
