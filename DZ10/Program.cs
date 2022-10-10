/* Задача 10: Напишите программу, которая принимает на 
вход трёхзначное число и на выходе показывает вторую цифру этого числа.
 */

System.Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(System.Console.ReadLine());
System.Console.WriteLine($"Вторая цифра этого числа: {num /10 %10}");