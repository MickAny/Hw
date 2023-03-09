// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76


double [] GetArray(int size)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.NextDouble()* (100 + 1) - 1;
        array[i] = Math.Round(array[i], 1);
       
    }
    return array;
}

Console.WriteLine("Введите размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());

double [] newArray = GetArray(a);

Console.Write("Массив: ");
for(int x=0; x<a; x++)
{
    Console.Write(newArray[x]+"  ");
}
Console.WriteLine();

double min =newArray[0], max = newArray[0];

for(int i=1; i<a;i++)
{
    if(newArray[i]>max){max=newArray[i];}

}
for(int i=1; i<a;i++)
{
    if(newArray[i]<min){min=newArray[i];}
}

Console.WriteLine("Самое большое число: "+ max+"\t"+"Самое маленькое число: "+ min);
double diff=max-min;
Console.Write("Разница между максимальным и минимальным элементами массива: "+diff);