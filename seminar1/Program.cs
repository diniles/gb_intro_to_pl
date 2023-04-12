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
  Console.WriteLine($"The first number {firstNum} is bigger.");
}
else if (firstNum < secondNum)
{
  Console.WriteLine($"The second number {secondNum} is bigger.");
}
else
{
  Console.WriteLine("The numbers are equal.");
}