// Задача 64: Задайте значение N. Напишите программу, которая найдет кол-во цифр в числе N рекурсивным методом.

int CountElements(int n)
{
    
    if(n >= 10)
    {
        return 1 + CountElements(n / 10);
    }
    return n;
}

Console.WriteLine(CountElements(123));
// 12345 -> 5

//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
int SumNumber(int m, int n)
{
    
    if(m < n)
    {
        return m + SumNumber(m + 1, n);
    }
   
   return m;
}

Console.WriteLine(SumNumber(0,10));
*/