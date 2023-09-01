// Задайте массив из 12 эелементов, заполненный случайными числами из промежутка [-9, 9] 
// Найдите сумму отрицательных и сумму положительных элементов массива.
// Например:
// [3, 9, -8, 1, 0, -7, 2, -1, 8, -3, -1, 6]
// сумма положительных чисел равна 29
// сумма отрицательных чисел равна -20

void FillArray (int[] ints)
{   Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
        ints[i] = rnd.Next(-9, 10);     
}

void PrintArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]} ");
    Console.WriteLine();   
}

int[] SumPosNegNums (int[] arr)
{
    int[] sums = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            sums[0] += arr[i];
        else
            sums[1] += arr[i];
    }
    return sums;
}

int[] newArray = new int[12];
FillArray(newArray);
PrintArray(newArray);
int[] result = SumPosNegNums(newArray);
PrintArray(result);
