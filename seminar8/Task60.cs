// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0, 1, 0)
// 34(1, 0, 0) 41(1, 1, 0)
// 27(0, 0, 1) 90(0, 1, 1)
// 26(1, 0, 1) 55(1, 1, 1)
public class Task60
{
  public static void run()
  {
    int x = Common.prompt("Enter number of x");
    int y = Common.prompt("Enter number of y");
    int z = Common.prompt("Enter number of z");

    int[,,] array = Common.fill3DArrayOfUniqueInts(x, y, z, 10, 100);

    Common.print3DArrayOfInts(array);
  }
}