﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

// Console.Write("Enter first number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());

// if (firstNum > secondNum)
// {
//   Console.WriteLine($"The first number {firstNum} is bigger than second number {secondNum}.");
// }
// else if (firstNum < secondNum)
// {
//   Console.WriteLine($"The second number {secondNum} is bigger than first number {firstNum}.");
// }
// else
// {
//   Console.WriteLine("The numbers are equal.");
// }

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

//P.S. Я не рассматривал случаи, когда все или некоторые из чисел равны, но, если надо, могу переделать.
// Console.Write("Enter first number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second number: ");
// int secondNum = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter third number: ");
// int thirdNum = Convert.ToInt32(Console.ReadLine());
// if (firstNum > secondNum && firstNum > thirdNum)
// {
//   Console.WriteLine($"The first number {firstNum} is biggest.");
// }
// if (secondNum > firstNum && secondNum > thirdNum)
// {
//   Console.WriteLine($"The second number {secondNum} is biggest.");
// }
// if (thirdNum > firstNum && thirdNum > secondNum)
// {
//   Console.WriteLine($"The third number {thirdNum} is biggest.");
// }

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).

// 4->да
// - 3->нет
// 7->нет

// Console.Write("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string result = number % 2 == 0 ? "Yes" : "No";
// Console.WriteLine($"{result}");


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе
// показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Console.Write("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int i = 2;
// while (i <= number)
// {
//   Console.Write($"{i} ");
//   i += 2;
// }