Console.WriteLine("Введите количество строк:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int b = Convert.ToInt32(Console.ReadLine());
int [,] arr1 = new int [a,b];


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        
        Console.WriteLine(""); 
    }
    Console.WriteLine();
}

void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 10);
            }   
    }
    Console.WriteLine();
}

void FindAverage(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {      
        double SumOfCol = 0;
        double Counter = 0;
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Counter++;
            SumOfCol += array [i,j];
        }
        Console.WriteLine("Среднее арифметическое столбца № " +(j+1)+" - " + Math.Round(SumOfCol/Counter, 2));
    }
}


FillArrayRandomNumbers(arr1);
PrintArray(arr1); 
FindAverage(arr1);
