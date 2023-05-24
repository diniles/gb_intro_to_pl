// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по
// убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

public class Task54
{
  public static void run()
  {
    int rows = Common.prompt("Enter number of rows");
    int cols = Common.prompt("Enter number of columns");

    int[][] jaggedArray = Common.fillJaggedArrayOfInts(rows, cols, 0, 99);

    Console.WriteLine("Initial array");
    Common.printJaggedArrayOfInts(jaggedArray);

    for (int i = 0; i < jaggedArray.Length; i++)
    {
      jaggedArray[i] = sortArray(jaggedArray[i]);
    }

    Console.WriteLine("\nSorted array");
    Common.printJaggedArrayOfInts(jaggedArray);
  }

  public static int[] sortArray(int[] jArray)
  {
    int length = jArray.Length;
    for (int i = 1; i < length; i++)
    {
      for (int j = 0; j < length - i; j++)
      {
        if (jArray[j] < jArray[j + 1])
        {
          int temp = jArray[j];
          jArray[j] = jArray[j + 1];
          jArray[j + 1] = temp;
        }
      }
    }
    return jArray;
  }
}