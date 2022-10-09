// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
void Zadacha34()
{
    int size = 10;
    double[] numbers = new double[size];
    FillArray(numbers);
    PrintArray(numbers);
    PoiskMinMax(numbers);
}

void PoiskMinMax(double[] numbers)
{
    double max = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Максимальное число " + max);

    double min = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    Console.WriteLine();
    Console.WriteLine("Минимальное число " + min);
    Console.WriteLine();
    Console.WriteLine($"Разница: {max} - {min} = {max - min}");
}

void FillArray(double[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.NextDouble();
    }
}

void PrintArray(double[] numbers)
{
    Console.WriteLine("вывод массива");
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Math.Round(numbers[i], 2);
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();
}

Zadacha34();

