// common functions for all tasks

public class Common
{
  public int prompt(string prompt)
  {
    Console.Write($"{prompt}: ");
    string input = Console.ReadLine();
    return int.Parse(input);
  }

  public int[] fillArrayOfInts(int size, int min, int max)
  {
    int[] array = new int[size];
    Random randomNumber = new Random();
    for (int i = 0; i < size; i++)
    {
      array[i] = randomNumber.Next(min, max + 1);
    }
    return array;
  }

  public double[] fillArrayOfDoubles(int size)
  {
    double[] array = new double[size];
    Random randomNumber = new Random();
    for (int i = 0; i < size; i++)
    {
      array[i] = randomNumber.NextDouble();
    }
    return array;
  }

  public void printArray(int[] array)
  {
    Console.Write("[");
    foreach (var item in array)
    {
      Console.Write($"{item}, ");
    }
    Console.Write("\b\b]");
  }
}

