// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
public class Task62
{
  public static void run()
  {
    int size = Common.prompt("Enter matrix size");

    int[,] matrix = fillMatrix(size);

    Common.print2DArrayOfInts(matrix);
  }


  public static int[,] fillMatrix(int size)
  {
    int[,] matrix = new int[size, size];

    int pos = 1;
    int count = size;
    int value = -size;
    int sum = -1;

    do
    {
      value = -1 * value / size;
      for (int i = 0; i < count; i++)
      {
        sum += value;
        matrix[sum / size, sum % size] = pos++;
      }
      value *= size;
      count--;
      for (int i = 0; i < count; i++)
      {
        sum += value;
        matrix[sum / size, sum % size] = pos++;
      }
    } while (count > 0);

    return matrix;
  }
}