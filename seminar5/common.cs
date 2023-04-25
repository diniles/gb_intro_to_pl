// common functions for all tasks
int prompt(string prompt)
{
  Console.Write($"{prompt}: ");
  string input = Console.ReadLine();
  return int.Parse(input);
}

int[] fillArrayOfInts(int size, int min, int max)
{
  int[] array = new int[size];
  Random randomNumber = new Random();
  for (int i = 0; i < size; i++)
  {
    array[i] = randomNumber.Next(min, max + 1);
  }
  return array;
}

double[] fillArrayOfDoubles(int size, double min, double max)
{
  double[] array = new double[size];
  Random randomNumber = new Random();
  for (int i = 0; i < size; i++)
  {
    array[i] = randomNumber.Next(min, max + 1);
  }
  return array;
}

void printArray(int[] array)
{
  Console.Write("[");
  foreach (var item in array)
  {
    Console.Write($"{item}, ");
  }
  Console.Write("\b\b]");
}