// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на
// выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.Write("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(number % 100 / 10);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или
// сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Enter the number: ");
string number = Console.ReadLine();
if (number.Length < 3)
{
  Console.WriteLine("No third number!");
}
else
{
  Console.WriteLine(number[2]);
}