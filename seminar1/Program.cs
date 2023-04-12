// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее.

// a = 5; b = 7->max = 7
// a = 2 b = 10->max = 10
// a = -9 b = -3->max = -3

Console.Write("Enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter first number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum > secondNum)
{
  Console.WriteLine($"The first number {firstNum} is bigger than second number {secondNum}.");
}
else if (firstNum < secondNum)
{
  Console.WriteLine($"The second number {secondNum} is bigger than first number {firstNum}.");
}
else
{
  Console.WriteLine("The numbers are equal.");
}

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22