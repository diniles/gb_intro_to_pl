// common functions for all tasks

public class Common
{
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
      array[i] = randomNumber.NextDouble() * 100;
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

  public static double[,] fill2DArrayOfDoubles(int rows, int cols)
  {
    double[,] array = new double[rows, cols];
    Random randomNumber = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j] = randomNumber.NextDouble() * 100;
      }
    }
    return array;
  }

  public static void print2DArrayOfDoubles(double[,] array)
  {
    Console.WriteLine("This is your array:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write("{0,6:F2}", array[i, j]);
      }
      Console.WriteLine();
    }
  }

  public static int[,] fill2DArrayOfInts(int rows, int cols, int min, int max)
  {
    int[,] array = new int[rows, cols];
    Random randomNumber = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i, j] = randomNumber.Next(min, max + 1);
      }
    }
    return array;
  }

  public static void print2DArrayOfInts(int[,] array)
  {
    Console.WriteLine("This is your array:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        Console.Write($"{array[i, j]}, ");
      }
      Console.WriteLine();
    }
  }
  public static int[][] fillJaggedArrayOfInts(int rows, int cols, int min, int max)
  {
    int[][] jaggedArray = new int[rows][];
    for (int i = 0; i < rows; i++)
    {
      jaggedArray[i] = new int[cols];
    }
    Random randomNumber = new Random();
    for (int i = 0; i < jaggedArray.Length; i++)
    {
      for (int j = 0; j < jaggedArray[i].Length; j++)
      {
        jaggedArray[i][j] = randomNumber.Next(min, max + 1);
      }
    }
    return jaggedArray;
  }

  public static void printJaggedArrayOfInts(int[][] jaggedArray)
  {
    Console.WriteLine("This is your array:");
    for (int i = 0; i < jaggedArray.Length; i++)
    {
      for (int j = 0; j < jaggedArray[i].Length; j++)
      {
        Console.Write($"{jaggedArray[i][j]}, ");
      }
      Console.WriteLine();
    }
  }
}
