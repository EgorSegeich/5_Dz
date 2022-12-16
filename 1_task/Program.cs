/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/


void FillArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int rnd = new Random().Next(99, 999);
        array[i] = rnd;
        Console.WriteLine(array[i]);
    } 
}


int [] arr = new int [10];
FillArray(arr);
int sum = 0;

for (int j = 0; j < arr.Length; j++)
{
    if(arr[j]%2 == 0)
    {
        sum++;
    }
}

Console.Write("количество чётных чисел в массиве: " + sum);