// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.

// M = 1; N = 15-> 120
// M = 4; N = 8. -> 30
public class Task66
{
  public static void run()
  {
    int m = prompt("Enter the start number");
    int n = prompt("Enter the end number");

    Console.WriteLine(sumOfNaturals(m, n));
  }

  public static int sumOfNaturals(int m, int n)
  {
    if (m == n)
    {
      return m;
    }
    else
    {
      return m + sumOfNaturals(m + 1, n);
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