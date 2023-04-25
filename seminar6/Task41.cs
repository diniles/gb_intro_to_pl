// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
// больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3
public class Task41
{
  public static void run()
  {
    Console.WriteLine("Enter the numbers by space:");
    string numbers = Console.ReadLine();
    string[] array = numbers.Split(" ");
    printArray(array);

    int counter = 0;
    foreach (string item in array)
    {
      if (int.Parse(item) > 0) counter++;
    }

    Console.WriteLine($"You entered {counter} positive numbers.");
  }
  static void printArray(string[] array)
  {
    Console.WriteLine("This is your array:");
    Console.Write("[");
    foreach (var item in array)
    {
      Console.Write($"{item}, ");
    }
    Console.WriteLine("\b\b]\n");
  }
}
