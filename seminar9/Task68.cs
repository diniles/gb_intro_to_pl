// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3->A(m, n) = 9
// m = 3, n = 2->A(m, n) = 29

public class Task68
{
  public static void run()
  {
    int m = prompt("Enter the start number");
    int n = prompt("Enter the end number");

    Console.WriteLine(ackermann(m, n));
  }

  public static int ackermann(int m, int n)
  {
    if (m == 0)
    {
      return n + 1;
    }
    else if (n == 0)
    {
      return ackermann(m - 1, 1);
    }
    else
    {
      return ackermann(m - 1, ackermann(m, n - 1));
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