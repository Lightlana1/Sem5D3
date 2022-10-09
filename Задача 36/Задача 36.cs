// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Zadacha36()
{
    int size = 7;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Poisk(numbers);
}

void Poisk(int[] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i = i + 2)
    {
        sum = sum + numbers[i];
    }
    Console.WriteLine();
    Console.WriteLine("Сумма чисел с нечетными индексами: " + sum);
}


void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(1,10);
    }
}

void PrintArray(int[] numbers)
{
    Console.WriteLine("вывод массива");
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

Zadacha36();