
double[,] CreateRandom2dArray(int rows, int columns, double minValue, double maxValue)
{
    double[,] newArray = new double[rows, columns];

    for(int i = 0; i < rows; i++) // по строкам
        for(int j = 0; j < columns; j++) // по всем элементам строки
            newArray[i,j] = new Random().NextDouble();
                
    return newArray;
}

void Show2dDoubleArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) // количество строк (0)
    {
        for(int j = 0; j < array.GetLength(1); j++) // количество строк (1)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

void Show2dArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) // количество строк (0)
    {
        for(int j = 0; j < array.GetLength(1); j++) // количество строк (1)
            Console.Write(array[i,j] + " ");
        
        Console.WriteLine();
    }
}

int[,] Create2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++) // по строкам
       
        for(int j = 0; j < columns; j++) // по всем элементам строки
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
}

void FindElementMassive(int[,] array)
{    
    int element = 0;
    Console.Write("Rows №: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Columns №: ");
    int y = Convert.ToInt32(Console.ReadLine());

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            if(i == (x-1) && j == (y-1)) 
                element += array[i,j];

            Console.WriteLine($"Element is {element}");
         
            
    Console.WriteLine("This number doesn't exist");
}

void AverageArithColums(int[,] array)
{
    double sum1 = 0;
    double average1 = 0;
    
    for(int i = 0; i < array.GetLength(0); i++)
        sum1 += array[i,0];
        average1 = sum1 / 5;

        
    double sum2 = 0;
    double average2 = 0;
    
    for(int i = 0; i < array.GetLength(0); i++)
        sum2 += array[i,1];
        average2 = sum2 / 5;

    double sum3 = 0;
    double average3 = 0;
    
    for(int i = 0; i < array.GetLength(0); i++)
        sum3 += array[i,2];
        average3 = sum3 / 5;

Console.WriteLine($"Среднее арифметическое каждого столбца: {average1}; {average2}; {average3}");
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
double min = Convert.ToDouble(Console.ReadLine());
Console.Write("Input max possible value: ");
double max = Convert.ToDouble(Console.ReadLine());

double[,] myArray = CreateRandom2dArray(m, n, min, max);
Show2dDoubleArray(myArray);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = Create2dArray(m, n, min, max);
Show2dArray(myArray);

FindElementMassive(myArray);
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
int m = 5;
int n = 3;
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2dArray(m, n, min, max);
Show2dArray(myArray);

AverageArithColums(myArray);
*/