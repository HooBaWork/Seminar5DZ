// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
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

int[] array = returnArray(4,100,1000);
Console.WriteLine(String.Join(" ",array));
int count = 0;

foreach(int number in array)
{   
    if(number%2==0)
    {
      count=count+1;
    }
}

Console.WriteLine($"Количество четных чисел -  {count}");
