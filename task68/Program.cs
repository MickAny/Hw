
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(a>0 && b>0?"Вычисление функции Аккермана: "+ Function(a, b):"Числа должны быть положительными!");
    

int Function(int a, int b)
{
if (a==0)   return b+1;
else if ((a!=0)&&(b==0))  return Function(a-1,1);
else return Function(a-1, Function(a,b-1));
}

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29*/
