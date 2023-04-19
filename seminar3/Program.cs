// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет,
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Enter the number: ");
string number = Console.ReadLine();

char[] arrayOfNums = number.ToCharArray();
Array.Reverse(arrayOfNums);
string reversedNumber = new string(arrayOfNums);

if (number == reversedNumber)
{
  Console.WriteLine("YES");
}
else
{
  Console.WriteLine("NO");
}