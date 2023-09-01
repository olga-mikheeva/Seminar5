// Создайте массив. Напишите программу которая определяет присутстует ли заданное число в массиве

void FindNum(int[] fNum, int num)
{
int count = 0;
for (int i = 0; i < fNum.Length; i++)
{
    if (fNum[i] == num)
    {
        count++;
    }
}
if (count == 0)
{
    Console.WriteLine("нет");
}
else
{
    Console.WriteLine("да");
}
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
       Console.Write(array[i]); 
       if (i < array.Length - 1) Console.Write(", ");
    } 
    Console.WriteLine();
}


int[] itsArray = {-6, 7, 19, 345, 3};
PrintArray(itsArray);
FindNum(itsArray, 7);


