// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и
// k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

public class Task43
{
  public static void run()
  {
    double b1 = prompt("Enter b1");
    double k1 = prompt("Enter k1");
    double b2 = prompt("Enter b2");
    double k2 = prompt("Enter k2");

    // double x = 0.0;
    // double y = 0.0;

    if ((k1 == k2) && (b1 == b2))
    {
      Console.WriteLine("Прямые совпадают");
    }
    else if (k1 == k2)
    {
      Console.WriteLine("Прямые параллельны");
    }
    else
    {
      double x = (b2 - b1) / (k1 - k2);
      double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
      Console.WriteLine($"X = {x}; Y = {y}");
    }

    static int prompt(string prompt)
    {
      Console.Write($"{prompt}: ");
      string input = Console.ReadLine();
      return int.Parse(input);
    }

  }
}