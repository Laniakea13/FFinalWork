int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
   array[i] = new Random().Next(0, 20);
   Console.Write(array[i] + " ");
}
int RunArray(int[] finarray)
{
    int count = 0;
    for (int i = 0; i < finarray.Length; i++)
    {
        if(array[i] % 2 == 0) count = count + 1;
        else count = count + 0;
    }
    return count;
}
Console.WriteLine();
Console.Write(RunArray(array));

// В двумерном массиве n×k заменить четные элементы на противоположные



/*void FillArray(int[] arr1)
{
    for (int i = 0; i < arr1.GetLength(0); i++)
    {
            arr1 = new Random().Next(1,10);
    }
}
void PrintArray(int[] matr);
{
   for(int i=0; i<matr.GetLength(0); i++)
   {
        Console.Write($"{matr[i]}  ");
       Console.WriteLine();
   }
}
/*void EvenArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i,j] % 2 == 0) matr[i,j] = matr[i,j] * -1;
        }
    }
}

Console.Write("Введите значение n -");
int n= int.Parse(Console.ReadLine());
Console.Write("Введите значение k -");
int k= int.Parse(Console.ReadLine());
Console.WriteLine();

int [,] matrix = new int[n,k];

FillArray(matrix);
PrintArray(matrix);
EvenArray(matrix);
Console.WriteLine();
PrintArray(matrix);*/