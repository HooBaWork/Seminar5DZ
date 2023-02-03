/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 

*/
Console.Clear();
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());


double[] resultArray = returnArray();//Забили массив с помощь функции,через которую пользователь вводит элементы массива

double[] returnArray()
{

   double[] array = new double[size];
   for(int i = 0;i < array.Length;i++)
   {
    
    Console.WriteLine("Введите вещественное число");
    array[i] = double.Parse(Console.ReadLine());
   }
   return array;
}

double difference(double[] resultArray) //Полученный массив отправляем в функцию ,для сравнения первого и последнего элементов массива
{
   double resultDif = resultArray[0]-resultArray[^1];

return resultDif;
}

double res = difference(resultArray);
Console.WriteLine($"Разница между первым и последним элементом массива {res}");
