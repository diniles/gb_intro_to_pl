// int prompt(string prompt)
// {
//   Console.Write($"{prompt} (if empty - 42): ");
//   string input = Console.ReadLine() ?? "42";
//   return int.Parse(input);
// }
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter a power: ");
// int power = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// int result = 1;
// while (i <= power)
// {
//   result *= number;
//   i++;
// }
// Console.WriteLine(result);

// refactoring rask 25:

// int toPower(int number, int power)
// {
//   int i = 1;
//   int result = 1;
//   while (i <= power)
//   {
//     result *= number;
//     i++;
//   }
//   return result;
// }

// int number = prompt("Enter a number");
// int power = prompt("Enter a power");

// int result = toPower(number, power);
// Console.WriteLine(result);

// ===============================================================================

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму
// цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

// Console.Write("Enter a number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int sum = 0;

// while (number > 0)
// {
//   sum += number % 10;
//   number /= 10;
// }

// Console.WriteLine(sum);

// refactoring task 27:

// int sumOfNumbers(int number)
// {
//   int sum = 0;

//   while (number > 0)
//   {
//     sum += number % 10;
//     number /= 10;
//   }
//   return sum;
// }

// int number = prompt("Enter a number");

// int result = sumOfNumbers(number);

// Console.WriteLine(result);

// ===============================================================================

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их
//  на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33-> [6, 1, 33]

// string[] array = new string[8];


// fillArray();
// printArray(array);


// void fillArray()
// {
//   for (int i = 0; i < 8; i++)
//   {
//     Console.Write("Enter a number: ");
//     array[i] = Console.ReadLine();
//   }

// }

// void printArray(string[] array)
// {
//   Console.Write("[");
//   foreach (var item in array)
//   {
//     Console.Write($"{item}, ");
//   }
//   Console.Write("\b\b]");
// }

// refactoring task 29:

// int[] fillArray(int size, int min, int max)
// {
//   int[] array = new int[size];
//   Random randomNumber = new Random();
//   for (int i = 0; i < size; i++)
//   {
//     array[i] = randomNumber.Next(min, max + 1);
//   }
//   return array;
// }

// void printArray(int[] array)
// {
//   Console.Write("[");
//   foreach (var item in array)
//   {
//     Console.Write($"{item}, ");
//   }
//   Console.Write("\b\b]");
// }

// int size = prompt("Enter size of array");
// int min = prompt("Enter minimum number for random function");
// int max = prompt("Enter maximum number for random function");

// int[] array = fillArray(size, min, max);
// printArray(array);