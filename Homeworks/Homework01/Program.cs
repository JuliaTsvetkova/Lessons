/*Задача 2
int a, b, max;

Console.Write("Input a numer 1: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numer 2: ");
b = Convert.ToInt32(Console.ReadLine());

max = a;

if (a > b)
{
    max = a;
    Console.WriteLine("max " + max);
}
 else 
 {
    max = b;
    Console.WriteLine("max " + max);
 }
*/
// Задача 4
/*
int a, b, c, max;

Console.Write("Input a numer 1: ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numer 2: ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a numer 3: ");
c = Convert.ToInt32(Console.ReadLine());

max = a;

if (b > max)
{
    max = b;
}

if (c > max)
{
    max = c;
}
Console.WriteLine("max " + max);
*/

// Задача 6
/*
int num;

Console.Write("Input a numer: ");
num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine("Число четное");

else
    Console.WriteLine("Число нечетное");
*/

// Задача 8

int n, current;

Console.Write("Input a number ");
n = Convert.ToInt32(Console.ReadLine());

current = 2;

while (current <= n)
{
    Console.Write(current + " ");
    current = current + 2; 
}

