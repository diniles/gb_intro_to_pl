// Задача 47.Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

public class Task47
{
  public static void run()
  {
    int rows = Common.prompt("Enter number of rows");
    int cols = Common.prompt("Enter number of columns");

    double[,] array = Common.fill2DArrayOfDoubles(rows, cols);

    Common.print2DArrayOfDoubles(array);
  }
}
