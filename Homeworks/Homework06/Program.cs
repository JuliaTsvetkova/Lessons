
int[] CreateArray(int size)

{
        int[] newArray = new int[size]; // выделяем память для массива

        Console.WriteLine($"Input {size} elements ");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Input {i+1} element: "); // поэлементно запрашиваем значения массива
            newArray[i] = Convert.ToInt32(Console.ReadLine()); // считываем со строки и записываем в массив
        }
        Console.WriteLine();
        return newArray;
}

int FindPositiveNumbers(int[] array)
{
    int result = 0;

    for(int i = 0; i < array.Length; i++)
        
        if(array[i] > 0)
         result = result + 1;
    
    return result;

}

void ShowArray(int[] array) 
{
    for (int i = 0; i < array.Length; i++) 
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArray(size);
ShowArray(array);
int positiveNum = FindPositiveNumbers(array);
Console.WriteLine("Numbers of positive elements is " + positiveNum);

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
/*
Console.Write("Input b1: ");
int b1 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input k1: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b2: ");
int b2 = Convert.ToInt32(Console.ReadLine());
 Console.Write("Input k2: ");
int k2 = Convert.ToInt32(Console.ReadLine());

double x1 = b2 - b1;
double x2 = k1 - k2;
double x = x1 / x2;
double y = k1 * x + b1;

    if (k1 == k2)
        Console.WriteLine("Lines are parallel"); 
            else if (k1 == k2 && b1 == b2)
                Console.WriteLine("Lines match");
    
    Console.WriteLine($"Cross point of lines is ({x}; {y})");
    */