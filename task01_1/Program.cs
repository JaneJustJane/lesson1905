// Определить, есть ли в массиве число 

int [] array = new int [8]{1,4,5,6,3,2,3,5};
Console.WriteLine ("введите число ");
int a = int.Parse(Console.ReadLine() ?? "0");
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
        if (array[j]==a)
        Console.WriteLine($"Число {a} - элемент массива под индексом {j}  ");
        if (array[j]!=a)
        Console.WriteLine($"Число {array[j]} - не {a}  ");
    }
}
search3(array);
