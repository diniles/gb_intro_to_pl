// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4-> 16

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a power: ");
int power = Convert.ToInt32(Console.ReadLine());
int i = 1;
int result = 1;
while (i <= power)
{
  result *= number;
  i++;
}
Console.WriteLine(result);