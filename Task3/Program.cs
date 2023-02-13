/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/ 

int MinOfArray (int[] arr)
{
    int min = arr[0];
    
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

int MaxOfArray (int[] arr)
{
    int max = arr[0];
    
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

int[] array = {2, 20, 68, 1582, 100, 458};
int minimum = MinOfArray(array);
int maximum = MaxOfArray(array);
System.Console.WriteLine($"Разница между максимальным и минимальным числами массива = {maximum - minimum}");

