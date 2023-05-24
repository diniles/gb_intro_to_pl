// Задача 64: Задайте значение N. Напишите программу, которая выведет все
// натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

public class Task64
{
  public static void run()
  {
    int number = prompt("Enter a number");
    Console.Write("\"");
    printNaturals(number);
    Console.Write("\b\b\"");
  }

  public static void printNaturals(int number)
  {
    if (number > 0)
    {
      Console.Write($"{number}, ");
      printNaturals(number - 1);
    }
  }

  public static int prompt(string prompt)
  {
    Console.Write($"{prompt} (if empty - 0): ");
    string? input = Console.ReadLine();
    if (input == null || input == "")
    {
      input = "0";
    }
    return int.Parse(input);
  }
}