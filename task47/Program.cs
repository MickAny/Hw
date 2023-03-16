int Promt(string message)
{
  Console.WriteLine(message);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

double[,] CreateOutputArray(int m, int n)
{
  Random x = new Random();
  double[,] arr = new double[m, n];
  for (int i = 0; i < arr.GetLength(0); i++)
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      arr[i, j] = Convert.ToDouble(x.Next(-10, 10)/10.0);
      Console.Write(arr[i, j] + " \t");
    }
    Console.WriteLine();
  }
  Console.WriteLine();
  return arr;
}

int m = Promt ("Введите количество строк: ");
int n = Promt ("Введите количество столбцов: ");

Console.WriteLine(CreateOutputArray(m, n));
