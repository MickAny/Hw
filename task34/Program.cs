// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int [] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

int [] newArray = GetArray(a);

int even_num=0;
Console.Write("Массив: ");
for(int x=0; x<a; x++)
{
    Console.Write(newArray[x]+" ");
}

Console.WriteLine(" ");

for(int x=0; x<a; x++)
{
    if(newArray[x]%2==0)
    {
        even_num++;
    }
}

Console.WriteLine("Четных чисел в массиве: "+even_num);