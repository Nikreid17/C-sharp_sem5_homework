// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int MinElement(int[] array)
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

int MaxElement(int[] array)
{
    int max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

int[] array = GetRandomArray(10, -999, 1000);
int min = MinElement(array);
int max = MaxElement(array);
Console.WriteLine($"[{String.Join(", ", array)}]");
int dif = max - min;
System.Console.WriteLine($"{max} - ({min}) = {dif}");