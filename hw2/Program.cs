﻿int numberA = new Random().Next(1,1000); 
Console.WriteLine(numberA);
int numberB = new Random().Next(1,1000);
Console.WriteLine(numberB);
int numberC = new Random().Next(1,1000); 
Console.WriteLine(numberC);
int max = numberA ;

if (numberA > max ) max = numberA;
if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;
Console.Write("max = ");
Console.WriteLine(max);