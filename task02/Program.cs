// Найти сумму чисел одномерного массива, стоящих на нечентой позиции

int[] array = new int [10]{2,13,0,1,4,5,6,7,8,9};
int sum = 0;
void UnEvenSum (int [] array)
{
    for (int i=0; i<array.Length; i++)
    {
        
        if (i%2>0)
        {
            sum = sum + array[i];
        }
    }
}
UnEvenSum (array);
Console.WriteLine($"Сумма чисел элементов массива на начетной позиции = {sum}");  