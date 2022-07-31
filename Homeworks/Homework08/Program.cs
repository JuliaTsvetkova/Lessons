int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++) // по строкам
        for(int j = 0; j < columns; j++) // по всем элементам строки
            newArray[i,j] = new Random().Next(minValue, maxValue + 1);
    
    return newArray;
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

int[,] DecreaseArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
  return array;
}
 
int SumInRows(int[,] array, int i)
{
        int sum = 0;
        for(int j = 0; j < array.GetLength(1); j++)
        {
            sum +=array [i,j];
             
        }
    return sum;    
} 

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2dArray(m,n,min,max);

// Задача 54:Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Show2dArray(myArray);

//Console.WriteLine("New massive:");
//Show2dArray(DecreaseArray(myArray));

// Задача 56:Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int minSumRow = 0;
int sumRow1 = SumInRows(myArray, 0);
for(int i = 1; i < myArray.GetLength(0); i++)
{
    int sumRow = SumInRows(myArray, i);
    if (sumRow < sumRow1)
    {
        sumRow1 = sumRow;
        minSumRow = i;
    }

}

Console.WriteLine($"Min sum elements {sumRow1} is in rows {minSumRow+1}");

