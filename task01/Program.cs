// Определить, есть ли в массиве число 3

int [] array = new int [8]{2,3,5,6,1,2,8,0};
void PrintArray(int [] array)
{
    for (int i=0; i<array.Length; i++)
    Console.Write($" {array[i]} ");
}
PrintArray (array);
Console.WriteLine();
void search3(int[] array)
{
    for (int j=0; j < array.Length; j++)
    {
        if (array[j]==3)
        Console.Write($"Число 3 - элемент массива под индексом {j}");

    }
}
search3(array);






