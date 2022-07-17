int[] CreateRandomArray(int size, int minValue, int maxValue ) // генерирует массив с рандомными числами от мин до макс
{
        int[] newArray  = new int[size]; // инициализация массива newArray

        for (int i = 0; i < size; i++)// присваиваем значение каждому элементу, i++ шаг в один
            newArray[i] = new Random().Next(minValue, maxValue +1); 

        return newArray;
}

void ShowArray(int[] array) // печатает массив
{
    for (int i = 0; i < array.Length; i++) // length определяет длину массива
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int EvenNumber(int[] array) // покажет количество чётных чисел в массиве
{
    int current = 0;

    for (int i = 0; i < array.Length; i++)
        if(array[i] % 2 == 0) current++;

   return current;
}

int SumOddNumber(int[] array) // находит сумму элементов, стоящих на нечётных позициях.
{
     int sum = 0;
     for (int i = 1; i < array.Length; i++)
        if(i % 2 == 1) sum += array[i];

     return sum;
}

double[] CreateRandomRealArray(int size) // генерирует массив с веществ.рандомными числами от мин до макс
{
        double[] newArray  = new double[size]; // инициализация массива newArray

        for (int i = 0; i < size; i++)// присваиваем значение каждому элементу, i++ шаг в один
            newArray[i] = new Random().Next(1, 10); 

        return newArray;
}

double DiffMinMax(double[] array) // находят разницу между мин и макс значением
{
    double diff = 0;
    int i_min = 0;
    int i_max = 0;

     for (int i = 1; i < array.Length; i++)
     {
        if(array[i] > array[i_max]) i_max = i;
        //Console.WriteLine(array[i_max]);
     
        if(array[i] < array[i_min]) i_min = i;
        //Console.WriteLine(array[i_min]);
     }

     diff = array[i_max] - array[i_min];
     return diff;
}

void ShowRealArray(double[] array) // печатает массив
{
    for (int i = 0; i < array.Length; i++) // length определяет длину массива
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible three-digit value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible three-digit value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
Console.WriteLine("Massive is: ");
ShowArray(array);

Console.WriteLine("Number of even numbers in the array is " + EvenNumber(array));
*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value of elements: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value of elements: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(size, min, max);
Console.WriteLine("Massive is: ");
ShowArray(array);
Console.WriteLine("Sum of odd position numbers is " + SumOddNumber(array));
*/
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] array = CreateRandomRealArray(size);
Console.WriteLine("Massive is: ");
ShowRealArray(array);

double difference = DiffMinMax(array);
Console.WriteLine("Difference between max and min elements is " + difference);
