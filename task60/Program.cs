int[,,] CreateNewArray()
{
    System.Console.WriteLine("Введите ширину массива:");
    int width = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите высоту массива:");
    int height = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите длинну массива:");
    int length = Convert.ToInt32(Console.ReadLine());
    int[,,] array = new int[width, height, length];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
            array[i, j, k] = new Random().Next(0, 10);
            }
        }
    }
    return array;
}

void PrintArray (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.Write( array[i, j, k] + "("+i+", "+j+", "+k+")"+"   ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}

void FixedArray(int[,,] array)
{
  int[] ExtraArr = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int  number;
  for (int i = 0; i < ExtraArr.GetLength(0); i++)
  {
    ExtraArr[i] = new Random().Next(10, 100);
    number = ExtraArr[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (ExtraArr[i] == ExtraArr[j])
        {
          ExtraArr[i] = new Random().Next(10, 100);
          j = 0;
          number = ExtraArr[i];
        }
          number = ExtraArr[i];
      }
    }
  }

  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = ExtraArr[count];
        count++;
      }
    }
  }
}

int [,,] array1 = CreateNewArray();
FixedArray(array1);
PrintArray(array1);







