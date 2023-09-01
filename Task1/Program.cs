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

void SumPosNegNums (int[] arr)
{
    int posSum = 0;
    int negSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
            posSum += arr[i];
        else
            negSum += arr[i];
    }
    Console.WriteLine($"Сумма положительных чисел равна {posSum}");
    Console.WriteLine($"Сумма отрицательных чисел равна {negSum}");
}

int[] newArray = new int[12];
FillArray(newArray);
PrintArray(newArray);
SumPosNegNums(newArray);
