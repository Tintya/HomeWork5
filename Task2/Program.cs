/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/ 

int[] InitArray()
{
    int[] result = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-99, 100);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
    System.Console.WriteLine();
}

int SumArray (int[] arr)
{   
    int sum = 0;
    for (int i = 0; i < arr.Length; i = i+2)
    {
        sum = sum + arr[i];
    }
    return sum;
    
}

int[] arr = InitArray();
PrintArray(arr);
int summ = SumArray(arr);
System.Console.WriteLine($"Сумма чисел с нечетным индексом = {summ}");

