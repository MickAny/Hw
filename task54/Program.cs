System.Console.WriteLine("Введите количество столбцов массива:");
int cols = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество строк массива:");
int rows = Convert.ToInt32(Console.ReadLine());

int[,] CreateNewMatrix(int cols, int rows)
{
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

Console.WriteLine("Новый двумерный массив: ");
int [,] array1 = CreateNewMatrix(rows ,cols);
PrintMatrix(array1);

Console.WriteLine("Двумерный массив, упорядоченный по убыванию: ");

for(int x=0;x<rows;x++)
{
    int[] arr = new int[cols];
    for (int y = 0; y < cols; y++)
    {
        arr[y] = array1[x, y];
    }
    Array.Sort(arr);

    for(int z=cols-1; z>=0;z--)
    {
        Console.Write(arr[z]+" ");
    }
    Console.WriteLine();
}

