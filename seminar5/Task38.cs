// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

public class Task38
{
  public static void run()
  {
    int size = Common.prompt("Enter array size");
    Console.WriteLine();
    double[] array = Common.fillArrayOfDoubles(size);

    double max = array[1];
    double min = array[1];

    foreach (double item in array)
    {
      if (item > max) max = item;
      if (item < min) min = item;
    }

    Common.printArrayOfDoubles(array);
    Console.WriteLine($"Maximum is {max}");
    Console.WriteLine($"Minimum is {min}");
    Console.WriteLine($"Difference is {max - min}");
  }
}
