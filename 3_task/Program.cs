/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.

[3.3 7.76 22 2 78.67] -> 76.67
*/


double[] CreateArray(int length)
{
    double[]array = new double[length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
        {
            array[i] = rnd.NextDouble() * 100;
            Console.WriteLine(array[i]);
        }
    return array;
}

double[] arr = CreateArray(5);


double min = arr[0];
double max = arr[0];

for (int j = 1; j < arr.Length; j++)
{
    if(arr[j] > max) max = arr[j];
    else if (arr[j] < min) min = arr[j];
}

double dif = max - min;

Console.WriteLine("минимальное: " + min + " максимальное: "+ max);
Console.WriteLine("разница между максимальным и минимальным элементом массива: " + dif);