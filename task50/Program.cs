
Console.WriteLine("Введите количество строк:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов:");
int b = Convert.ToInt32(Console.ReadLine());
int [,] arr1 = new int [a,b];
Console.WriteLine("Введите число для проверки на наличие:");
int cw = Convert.ToInt32(Console.ReadLine());


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
}

void CheckPresence(int[,] array, int x)
{
    int d=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(x == array[i, j])
            {
                d++;
            }

        }
    }
    if(d==0){Console.WriteLine("Такого числа в массиве нет!");}
    if(d>0){Console.WriteLine("Такое число в массиве есть!");}
}


FillArrayRandomNumbers(arr1);
PrintArray(arr1);
CheckPresence(arr1, cw);




