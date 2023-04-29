// Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее
// арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

public class Task52
{
  public static void run()
  {
    int rows = Common.prompt("Enter number of rows");
    int cols = Common.prompt("Enter number of columns");

    int[,] array = Common.fill2DArrayOfInts(rows, cols, 0, 99);

    Common.print2DArrayOfInts(array);



    for (int i = 0; i < array.GetLength(1); i++)
    {
      double sumOfColumn = 0;
      for (int j = 0; j < array.GetLength(0); j++)
      {
        sumOfColumn += array[j, i];
      }
      double average = sumOfColumn / array.GetLength(1);
      Console.WriteLine("The average is {0:F2}", average);
    }
  }
}