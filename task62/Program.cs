int[,] arr1 = new int[4, 4];
int[,] arr2 = new int[4, 4];

int m = 1;
Console.WriteLine("Первоначальный массив");
for(int x=0;x<4;x++)
{
  for(int y=0;y<4;y++)
   {
    arr1[x, y] = m;
    if(arr1[x, y]<10) Console.Write("0"+arr1[x, y]+" ");
    else Console.Write(arr1[x, y]+" ");
    m++;
   }
 Console.WriteLine();
}

int i = 0;
for(int j=0;j<4;j++)
{
 arr2[i, j] = arr1[i, j];
}

int a = 0;
int b = 3;
for(int x=1;x<4;x++)
{
  for (int y = 0; y < 4; y++)
  {
    if(a==2 && b==2) {
    arr2[a, b] = arr1[x, y];
    b--;
    }
    if(a==1 && b==2) {
    arr2[a, b] = arr1[x, y];
    a++;
    }
    if (a==1 && b<2) {
    arr2[a, b] = arr1[x, y];
    b++;
    }
    if (a >= 1 && b == 0) {
    arr2[a, b] = arr1[x, y];
    a--;
    }
    if (a < 3 && b == 3) {
    ++a;
    arr2[a, b] = arr1[x, y];
    }
    if (a == 3 && b > 0) {
    arr2[a, b] = arr1[x, y];
    b--;
    }
    if(a==2 && b==1) arr2[a, b] = arr1[x, y];
  }
}


Console.WriteLine("Массив, выведенный по спирали");

for(int x=0;x<4;x++)
{
  for(int y=0;y<4;y++)
   {
     if(arr2[x, y]<10) Console.Write("0"+arr2[x, y]+" ");
     else Console.Write(arr2[x, y]+" ");
    }
 Console.WriteLine();
}