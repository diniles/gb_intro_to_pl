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
    int cols = Common.prompt("Enter number of columns");

    int[,] firstMatrix = Common.fill2DArrayOfInts(rows, cols, 0, 9);


    Console.WriteLine("First matrix");
    Common.print2DArrayOfInts(firstMatrix);


    rows = Common.prompt("Enter number of rows");
    cols = Common.prompt("Enter number of columns");
    int[,] secondMatrix = Common.fill2DArrayOfInts(rows, cols, 0, 9);

    Console.WriteLine("\nSecond matrix");
    Common.print2DArrayOfInts(secondMatrix);

    // for test purpose only
    // int[,] firstMatrix = new int[2, 2];
    // firstMatrix[0, 0] = 2;
    // firstMatrix[0, 1] = 4;
    // firstMatrix[1, 0] = 3;
    // firstMatrix[1, 1] = 2;

    // int[,] secondMatrix = new int[2, 2];
    // secondMatrix[0, 0] = 3;
    // secondMatrix[0, 1] = 4;
    // secondMatrix[1, 0] = 3;
    // secondMatrix[1, 1] = 3;


    if (firstMatrix.GetLength(1) != secondMatrix.GetLength(0))
    {
      throw new Exception("These matrices can not be multiplicated!");
    }

    Common.print2DArrayOfInts(matrixMultiplication(firstMatrix, secondMatrix));
  }
  public static int[,] matrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
  {
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
      for (int j = 0; j < secondMatrix.GetLength(1); j++)
      {
        for (int k = 0; k < secondMatrix.GetLength(0); k++)
        {
          result[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
        }
      }
    }
    return result;
  }
}