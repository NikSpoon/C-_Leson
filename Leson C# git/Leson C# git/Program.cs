
int a = 4531;

var a1 = a / 1000;
var a2 = (a - (a1*1000)) / 100;
var a3 = (a - (a1 * 1000) - (a2*100)) / 10;
var a4 = (a - (a1 * 1000) - (a2 * 100)- (a3*10));


Console.WriteLine(a1);
Console.WriteLine(a2);
Console.WriteLine(a3);
Console.WriteLine(a4);
Console.WriteLine(a);

Console.ReadLine();