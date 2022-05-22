
// написать программу замены эл-тов массива на противоположные

int [] array = new int[5]{5,3,2,6,9};
PrintArray(array);
void PrintArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write($"  {array[i]} ");
}
Console.WriteLine();
ChangeArray(array);
void ChangeArray(int [] array)
{
    for (int j = 0; j < array.Length; j++)
    array[j]= -array[j];

}
PrintArray(array);

