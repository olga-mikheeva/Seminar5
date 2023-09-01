// Создайте массив. Напишите программу которая определяет присутстует ли заданное число в массиве



void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i]); 
       if (i < array.Length - 1) Console.Write(", ");
    } 
    Console.WriteLine();
}

string FindNum(int[] ints, int searching)
{
    for (int i = 0; i < ints.Length; i++)
        if (ints[i] == searching)
            return "да";
    
    return "нет";
}

int[] smth = {1, 2, 3, 4, 5};
PrintArray(smth);
Console.WriteLine(FindNum(smth, 6));
