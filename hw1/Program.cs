double a; double b; double c;
Console.WriteLine("a =");
a = inputValue();
Console.WriteLine("b =");
b = inputValue();
Console.WriteLine("c =");
c = inputValue();
double max = 0;
double min = 0;

if (a>b)
{
    max = a; min = b;
    Console.Write("max=");
    Console.WriteLine(max);
    Console.Write("min=");
    Console.WriteLine(min);
}
else
{
    max = b; min = a;
    Console.Write("max=");
    Console.WriteLine(max);
    Console.Write("min=");
    Console.WriteLine(min);
}