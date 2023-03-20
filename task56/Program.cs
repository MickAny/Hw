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

int MinRow=0, MinSum=0;
for (int i = 0; i < rows; i++)
{
    int sum=0;
    for (int j = 0; j < cols; j++)
    {
      sum+=array1[i, j];
      if(i==0)MinSum = sum;
    }
    Console.WriteLine("Сумма всех элементов строки: "+sum);
   
   if(sum<MinSum)
   {
    MinSum= sum; 
    MinRow = i;
   }
}
Console.WriteLine("Строка с наименьшей суммой элементов: №" + ++MinRow);