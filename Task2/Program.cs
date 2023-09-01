// напишите прошграмму замены эелементов массива. 
//Положительные элементы замените на соответствующие отрицательные и наоборот

void ChangeSign(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    arr[i] *= -1;
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


int[] itsArray = {-1, -6, 10, -17, 28, 8, 0, 7};
PrintArray(itsArray);
ChangeSign(itsArray);
PrintArray(itsArray);



