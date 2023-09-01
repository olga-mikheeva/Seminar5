// найти произведение пар чисел в одномерном массиве. Пары считать так: первый элемент и последний,
// второй и предпоследний. Результат записать в новом массиве
// Если у числа нет пары то это число переходит в новый массив в неизменном виде

// создадим массив в функции, передадим этой функции размер массива и вернем new int размером size

// функция запроса числа

int InputNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateArray(int size)
{
    return new int[size];
}

// заполним массив, т.к. уже есть массив используем void, в нем передадим массив, и диапазон.  в теле создаем объект класса Random

void FillArray(int[] array, int minValue, int maxValue)
{
Random rnd = new Random();
for (int i = 0; i < array.Length; i++)
    array[i] = rnd.Next(minValue, maxValue + 1);
}

// выводим на печать
void PrntArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();   
}

// дальше нужна функция которая будет создавать и возвращать новый массив
// для содания нужно определиться с размером массива: если четный то он будет равено половине старого, если нет, то половине старого +1. Поможет действие остаток от деления
// 3 / 2 = 1  3 % 2 = 1  
// int size = array.Length / 2
// if (array.Length % 2 == 1) size++;

int[] MultPairs(int[] array)
{
int size = array.Length / 2 + array.Length % 2;
int[] newArr = new int[size]; // создаем массив
for (int i = 0; i < array.Length / 2; i++)
    newArr[i] = array[i] * array[array.Length - 1 - i];

    if (array.Length % 2 == 1)
        newArr[size - 1] = array[array.Length / 2];
    return newArr;
}

int size = InputNum("Введите размер массива: ");
int[] ints = CreateArray(size);

int min = InputNum("Введите минимальное значение эелемента массива: ");
int max = InputNum("Введите максимальное значение элемента массива: ");

FillArray(ints, min, max);
PrntArray(ints);

int[] result = MultPairs(ints);
PrntArray(result);


