// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

public class Task58
{
  public static void run()
  {
    int rows = Common.prompt("Enter number of rows");
    int cols = Common.prompt("Enter number of columns (same as rows)");

    int[][] firstMatrix = Common.fillJaggedArrayOfInts(rows, cols, 0, 9);

    Console.WriteLine("First matrix");
    Common.printJaggedArrayOfInts(firstMatrix);

    int[][] secondMatrix = Common.fillJaggedArrayOfInts(rows, cols, 0, 9);

    Console.WriteLine("\nSecond matrix");
    Common.printJaggedArrayOfInts(secondMatrix);

  }
}