void CreateArray(int[] arr1)
{
    for (int i = 0; i < arr1.Length; i++)
    {
            arr1[i] = new Random().Next(0,11);
    }
}
void PrintArray(int[] arr)
{
   for(int i=0; i<arr.Length; i++)
   {
        Console.Write($"{arr[i]}  ");
   }
}
int[] RunArray(int[] finarray)
{
    int count = 0;
    for (int i = 0; i < finarray.Length; i++)
    {
        if(finarray[i] % 2 == 0) count = count + 1;
        else count = count + 0;
    }
    int[] fin = new int[count];
    int index = 0;
     for (int i = 0; i < finarray.Length; i++)
     {
        if(finarray[i] % 2 ==0) fin[index++] = finarray[i];
     }
  return fin;
}
int[] startArray = new int[10];
CreateArray(startArray);
PrintArray(startArray);
Console.WriteLine();
RunArray(startArray);
PrintArray(RunArray(startArray));
