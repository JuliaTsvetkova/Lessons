// принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrom (int num)
{
    int a1 = num / 10000;
    int a2 = (num / 1000) % 10;
    int a4 = (num % 100) / 10;
    int a5 = num % 10;

    if (a1 == a5)
    {
        if (a2 == a4)
        Console.WriteLine("Yes, it is palindrom");
    }
    else Console.WriteLine("No, it is not palindrom");
}

Console.WriteLine("Input five-digit number: "); 
int num = Convert.ToInt32(Console.ReadLine());

Palindrom (num);

// принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

/*void CubeTabl(int n)
{
    int current = 1;
    
    while (current <= n)
    {
        int cube = current*current*current;
        Console.Write(cube + " "); 
        current ++;
    }

}

Console.WriteLine("Input a number "); 
int n = Convert.ToInt32(Console.ReadLine());
    
CubeTabl(n);
*/
