// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int [] newArray = GetArray(a);
int sum=0;

Console.Write("Массив: ");
for(int x=0; x<a; x++)
{
    Console.Write(newArray[x]+" ");
}
Console.WriteLine();


for(int i=1; i<a; i+=2)
{
    sum +=newArray[i];
}

Console.Write("Сумма элементов на нечетных позициях: "+sum);






