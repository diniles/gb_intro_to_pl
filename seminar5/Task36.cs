// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите
// сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6]-> 0

public class Task36
{
  public static void run()
  {
    int size = Common.prompt("Enter array size");
    Console.WriteLine();
    int[] array = Common.fillArrayOfInts(size, -100, 101);

    int sumOfOdds = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
      sumOfOdds += array[i];
    }
    Common.printArray(array);
    Console.WriteLine($"Sum of odds positions is {sumOfOdds}");
  }
}
