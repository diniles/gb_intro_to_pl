// common functions for all tasks

public class Common
{
  public static int prompt(string prompt)
  {
    Console.Write($"{prompt} (if empty - 42): ");
    string input = Console.ReadLine() ?? "42";
    return int.Parse(input);
  }

  public static int[] fillArrayOfInts(int size, int min, int max)
  {
    int[] array = new int[size];
    Random randomNumber = new Random();
    for (int i = 0; i < size; i++)
    {
      array[i] = randomNumber.Next(min, max + 1);
    }
    return array;
  }

  public static double[] fillArrayOfDoubles(int size)
  {
    double[] array = new double[size];
    Random randomNumber = new Random();
    for (int i = 0; i < size; i++)
    {
      array[i] = randomNumber.NextDouble();
    }
    return array;
  }

  public static void printArray(int[] array)
  {
    Console.WriteLine("This is your array:");
    Console.Write("[");
    foreach (var item in array)
    {
      Console.Write($"{item}, ");
    }
    Console.WriteLine("\b\b]\n");
  }
  public static void printArrayOfDoubles(double[] array)
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
