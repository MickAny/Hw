


    

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a<b?"Сумма чисел от a до b равна: " + RetSum(a, b)
:a==b?"Число a равно числу b!":"Число a меньше числа b!");
    

int RetSum(int a, int b)
{
if(a==b) return b;
return a + RetSum(a+1, b);
}


/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/
