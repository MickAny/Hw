int[,] CreateNewMatrix()
{
    System.Console.WriteLine("Введите количество строк матрицы:");
    int cols = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов матрицы:");
    int rows = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[cols, rows];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        
        Console.WriteLine(""); 
    }
}

Console.WriteLine("Инициализируйте первую матрицу:" );
int [,] arr1 = CreateNewMatrix();
PrintMatrix(arr1);
Console.WriteLine("Инициализируйте вторую матрицу:\t" );
int [,] arr2 = CreateNewMatrix();
PrintMatrix(arr2);

int x = arr1.GetLength(0);
int y = arr2.GetLength(0);
int z = arr2.GetLength(0);


int[,] arr3 = new int[x, y];

for (int i = 0; i < x; i++) 
{
  for (int j = 0; j < y; j++) 
   {
     for (int k = 0; k < z; k++) 
      {
       arr3[i, j] += arr1[i, k] * arr2[k, j];
      }
    }
}

Console.WriteLine("___________________________");

for (int i = 0; i < arr3.GetLength(0); i++) 
{
    for (int j = 0; j < arr3.GetLength(1); j++) 
    {
     Console.Write( arr3[i, j]+" ");
    }
    Console.WriteLine();
} 
