// В массиве вещественных чисел найти разницу между макс и мин элементом

double[] array = new double [10]{2.6,13,110.9,1,4,5,6,7,8,9};
void PrintArray(double [] array)
{
for (int i=0; i<array.Length; i++)
Console.Write($" {array[i]} ");
}
PrintArray (array); 
Console.WriteLine();

double max=array[0];
double min=array[0];
for (int j=0; j<array.Length; j++)
{ 
    if (array[j]>max)  max = array[j];
    if (array[j]<min)  min = array[j];
}
double result = max - min;
Console.WriteLine ($"разница между макс и мин эл-ми массива = {result}");