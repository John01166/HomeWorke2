/* Задача 15:
 Напишите программу, которая принимает на вход цифру, обозначающую
 день недели, и проверяет, является ли этот день выходным. */

 System.Console.WriteLine("Введите номер дня недели");
int day = Convert.ToInt32(System.Console.ReadLine());
    if (day>=1 && day<=5) System.Console.WriteLine("НЕТ, это рабочий день");
    if (day>=6 && day<=7) System.Console.WriteLine("ДА - это Выходной день");
else System.Console.WriteLine("В неделе 7 дней, введите число заново");