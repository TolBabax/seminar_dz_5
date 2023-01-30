// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

void PrintArray(int[] arr) //Вывод массива на экран
{
    System.Console.WriteLine("[" + string.Join(", ", arr) + "]");
}

void PrintEvenNumber(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            System.Console.Write(arr[i] + " ");
        }
    }
}


int[] array = FillArrayWithRandomNumbers(10, 100, 999);
System.Console.WriteLine("Изначальный массив: ");
PrintArray(array);
System.Console.Write("Четные числа массива: ");
PrintEvenNumber(array);
