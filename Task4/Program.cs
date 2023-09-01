// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива значения которых лежат в отрезке от 10 до 99

void FillArray (int[] ints)
{   Random rnd = new Random();
    for (int i = 0; i < ints.Length; i++)
        ints[i] = rnd.Next(0, 200);     
}

int AmountNumsInDiap (int[] array, int start, int end)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if(array[i] >= start && array[i] <= end) 
       count ++;
    }
    return count;
}

int[] arrayForNumbers = new int [123];
FillArray(arrayForNumbers);
int result = AmountNumsInDiap(arrayForNumbers, 10, 99);
Console.WriteLine(result);