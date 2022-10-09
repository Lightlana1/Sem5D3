// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void Zadacha34()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers);
    PrintArray(numbers);
    Poisk(numbers);
}

void Poisk(int[] numbers)
{
    Console.WriteLine("Четные числа");
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 1)
        {
            Console.Write(numbers[i] + " ");
            count++;
        }
        
    }
    Console.WriteLine();
    Console.WriteLine("Количество четный чисел " + count);
}


void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(100,999);
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

Zadacha34();


