// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая
// будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка
public class Task56
{
  public static void run()
  {
    int rows = Common.prompt("Enter number of rows");
    int cols = Common.prompt("Enter number of columns");

    int[][] jaggedArray = Common.fillJaggedArrayOfInts(rows, cols, 0, 99);

    Common.printJaggedArrayOfInts(jaggedArray);

    int minSum = Int32.MaxValue;
    int minRow = 0;

    for (int i = 0; i < jaggedArray.Length; i++)
    {
      int sum = sumOfElements(jaggedArray[i]);
      if (minSum > sum)
      {
        minSum = sum;
        minRow = i;
      }
    }
    Console.WriteLine($"{minRow + 1} line");
  }

  public static int sumOfElements(int[] jArray)
  {
    int sum = 0;
    foreach (var el in jArray)
    {
      sum += el;
    }
    return sum;
  }
}