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

    int[,] array = Common.fill2DArrayOfInts(rows, cols, 0, 99);

    Common.print2DArrayOfInts(array);

    for (int i = 0; i < array.GetLength(0); i++)
    {
      // array[0, i] = sortArray(array[0,i]);
      int[] tmpArr = array[, i];
      // Common.printArray(array[i, 0]);
    }

    // Common.print2DArrayOfInts(array);
  }

  public static int[] sortArray(int[] array)
  {
    int length = array.Length;
    for (int i = 1; i < length; i++)
    {
      for (int j = 0; j < length - i; j++)
      {
        if (array[j] < array[j + 1])
        {
          int temp = array[j];
          array[j] = array[j + 1];
          array[j + 1] = temp;
        }
      }
    }
    return array;
  }
}