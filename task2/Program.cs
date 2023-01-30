// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] FillArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}

void PrintArray(int[] arr) 
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void SumOddElements(int[] arr, out int sumO)
{
    sumO = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 != 0)
        {
            sumO += arr[i];
        }

    }
}

int[] array = FillArrayWithRandomNumbers(10, 1, 20);
System.Console.WriteLine("Изначальный массив: ");
PrintArray(array);

SumOddElements(array, out int sumO);
System.Console.WriteLine($"Сумма всех нечетных элементов массива: {sumO}.");
