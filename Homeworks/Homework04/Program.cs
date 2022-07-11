// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SumNum(int N)
{
    int result = 0;

    while (N > 0)
   {
    int digit = N % 10;
    result = result + digit;
    N = N / 10;
   }
   return result;
}

 Console.Write("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = SumNum (num);
Console.WriteLine($"Summa of numbers {num} is {res}");

// Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.
/*
void FullArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
       collection [index] = new Random().Next(1,10);
       index ++;
    }
}

void PrintArray (int [] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Console.WriteLine(collection[index]);
        index ++;
    }
}

Console.Write("Input a number of array elements: ");
int m = Convert.ToInt32(Console.ReadLine());

int[] array = new int[m];
FullArray(array);
PrintArray(array);
*/