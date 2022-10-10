/* Задача 13: Напишите программу, которая выводит третью цифру СЛЕВА заданного
 числа или сообщает, что третьей цифры нет.Console.WriteLine("Hello, World!");
 */
 Console.Clear();
 System.Console.WriteLine("Введите число");
 int num1 = Convert.ToInt32(System.Console.ReadLine());
 if (num1>99)
  {
    while (num1>999)
    {
        num1 = num1/10;
    }
    System.Console.WriteLine($"Третья цифра слева:{num1%10}");
  }
 else System.Console.WriteLine("Третьей цифры нет"); 