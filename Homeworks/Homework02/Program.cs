// Задача 10: принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void SecondNumber()  
{
   int number;
   Console.WriteLine("Введите трехзначное число "); 
   number = Convert.ToInt32(Console.ReadLine());

    while (number > 1000 ^ number < 100)
   {
    Console.WriteLine("Введите другое число "); 
    number = Convert.ToInt32(Console.ReadLine());
   }
    
    int noed = number / 10;
    int result = noed % 10;
    Console.WriteLine("Вторая цифра введеного числа " + result);
}

SecondNumber();


// Задача 13: выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNumber() 
{
    int number;
   Console.WriteLine("Введите число "); 
   number = Convert.ToInt32(Console.ReadLine());

if (number > 99)
{
   while (number > 999)
   {
    number = number / 10;
   }
   
   int result = number % 10;
   Console.WriteLine("Третья цифра " + result);
}
else
   Console.WriteLine("Третьей цифры нет");
}

ThirdNumber();


// Задача 15: принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

/*void DayWeek ()
{
   int daynum;
   Console.WriteLine("Введите номер дня недели: ");
   daynum = Convert.ToInt32(Console.ReadLine());

   if (daynum == 6 ^ daynum == 7)
   Console.WriteLine("Да");

   else
   Console.WriteLine("Нет");
}

DayWeek ();
*/
