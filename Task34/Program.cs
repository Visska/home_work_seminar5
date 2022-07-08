/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
*/

int[] fillArrayNumber(int length, int startBorder, int endBorder)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(startBorder, endBorder);
    }
    return resultArray;
}

int evenNumberArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void printArray(int[] array)
{
    Console.Write("[");
    for (var i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}");
        if(i < array.Length-1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

Console.Clear();
int[] randomNumberArray = fillArrayNumber(4, 100, 1000);
printArray(randomNumberArray);
int evenNum = evenNumberArray(randomNumberArray);
Console.WriteLine($"Количество четных чисел в массиве равно {evenNum}");