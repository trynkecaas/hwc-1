int a = -8;
int b = -5;
int max = 0;
int min = 0;

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