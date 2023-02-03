/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 

*/
Console.Clear();

int size = main();//Вызов главной функции для указания размера массива

int main(int resul)
{
Console.WriteLine("Введите размер массива");
int size = int.Parse(Console.ReadLine());

return size;

}

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

double difference(double a,double b)// Вычитаем из первого последний элемент массива,что бы узнать разницу между ними .Первый элемент массива [0],последнй [-1].
{
double resultDif = a - b;
return resultDif;
}
double res = difference(resultArray[0],resultArray[-1]);
Console.WriteLine(res);
