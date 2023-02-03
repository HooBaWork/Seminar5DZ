/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */
Console.Clear();

int[] returnArray(int size,int minNumber, int maxNumber)
{
   int[] array = new int[size];
   for(int i = 0;i < size;i++)
   {
    array[i] = new Random().Next(minNumber,maxNumber); 
   }
   return array;
}

int findSum(int[] array)
{    
    int sum = 0;
    for(int i = 0;i < array.Length;i++)
    {
       if(i==0)
       {
         sum=sum+array[i];
       }
       else if(i%2==0)
       {
        sum=sum+array[i];
       }
    }
    return sum;
}

 int[] array = returnArray(4,100,1000);
 Console.WriteLine(String.Join(" ",array));
 int sum = findSum(array);
 Console.WriteLine($"Сумма элементов,стоящих на нечетных позициях {sum}");
