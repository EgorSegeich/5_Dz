/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int rnd = new Random().Next(1,10);
        array[i] = rnd;
        Console.WriteLine(array[i]);
    } 
}

int [] arr = new int [10];
FillArray(arr);
int sum = 0;

for (int j = 1; j < arr.Length; j=j+2)
{
    sum = sum + arr[j];
}

Console.Write("сумма элементов, стоящих на нечётных позициях: " + sum);