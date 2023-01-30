// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rand.Next(leftRange, rightRange + 1) + rand.NextDouble(), 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

double MaxElements(double[] arr)
{
    double maxE = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (maxE < arr[i])
        {
            maxE = arr[i];

        }
        else
        {
            maxE = maxE;
        }
    }
     return maxE;
}

double MinElements(double[] arr)
{
    
    double minE = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (minE > arr[i])
        {
            minE = arr[i];
        }
        else
        {
            minE = minE;
        }
    }
    return minE;
}

double[] array = FillArrayWithRandomNumbers(10, 1, 20);
System.Console.WriteLine("Изначальный массив: ");
PrintArray(array);
double numberDiff = Math.Round(MaxElements(array) - MinElements(array), 2);

System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива: {numberDiff}.");
