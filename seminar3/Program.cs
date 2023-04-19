// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.Write("Enter the number: ");
// string number = Console.ReadLine();

// char[] arrayOfNums = number.ToCharArray();
// Array.Reverse(arrayOfNums);
// string reversedNumber = new string(arrayOfNums);

// if (number == reversedNumber)
// {
//   Console.WriteLine("YES");
// }
// else
// {
//   Console.WriteLine("NO");
// }

// ==========================================================================

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Write("Enter the first point X: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the first point Y: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the first point Z: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second point X: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second point Y: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the second point Z: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// double distX = Math.Pow((x2 - x1), 2);
// double distY = Math.Pow((y2 - y1), 2);
// double distZ = Math.Pow((z2 - z1), 2);

// Console.WriteLine(Math.Sqrt(distX + distY + distZ));

// ==========================================================================

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
  Console.Write($"{Math.Pow(i, 3)} ");
}