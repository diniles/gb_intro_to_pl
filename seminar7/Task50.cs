// Задача 50.Напишите программу, которая на вход принимает позиции элемента в
// двумерном массиве, и возвращает значение этого элемента или же указание, что
// такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17->такого числа в массиве нет

public class Task50
{
  public static void run()
  {
    Console.WriteLine("The task is not entirely clear to search for an element or by position number, so I did both options");

    int rows = Common.prompt("Enter number of rows");
    int cols = Common.prompt("Enter number of columns");

    int[,] array = Common.fill2DArrayOfInts(rows, cols, 0, 100);

    Common.print2DArrayOfInts(array);

    searchByPosition(array);
    searchByElement(array);

  }
  public static void searchByPosition(int[,] array)
  {
    Console.WriteLine("Now searching by position!\n");
    int elRow = Common.prompt("Enter element row position");
    int elCol = Common.prompt("Enter element column position");
    Console.WriteLine();

    if (elRow < array.GetLength(0))
    {
      if (elCol < array.GetLength(1))
      {
        Console.WriteLine($"Element is {array[elRow, elCol]}");
      }
      else
      {
        Console.WriteLine("Wrong element position");
      }
    }
    else
    {
      Console.WriteLine("Wrong element position");
    }
  }

  public static void searchByElement(int[,] array)
  {
    Console.WriteLine("Now searching by element!\n");
    int element = Common.prompt("Enter element");

    Console.WriteLine();

    String position = "Not found";

    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        if (array[i, j] == element)
        {
          position = "Element is on position: " + i + " " + j;
        }
      }
    }
    Console.WriteLine(position);
  }
}