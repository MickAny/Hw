// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int a = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[a];

for(int i=0; i<a;i++)
{
    Console.WriteLine("Введите число №"+(i+1)+":");
    arr[i]=Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Массив: ");
foreach(int x in arr)
{
    Console.Write(x+" ");
}
Console.WriteLine();


Console.WriteLine("Количество чисел больше 0: ");
int b=0;
foreach(int x in arr)
{
    if(x>0){b++;}
}
Console.Write(b);