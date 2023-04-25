// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

public class Task34
{
  public static void run()
  {
    int size = Common.prompt("Enter array size");
    Console.WriteLine();
    int[] array = Common.fillArrayOfInts(size, 100, 1000);

    int qtyOfEvens = 0;
    foreach (int item in array)
    {
      if (item % 2 == 0) qtyOfEvens++;
    }
    Common.printArray(array);
    Console.WriteLine($"Total {qtyOfEvens} even numbers");
  }
}
