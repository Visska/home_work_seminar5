/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
*/

int[] fillArrayNumber(int length, int startBorder, int endBorder)
{
    int[] resultArray = new int[length];
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(startBorder, endBorder+1);
    }
    return resultArray;
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

int sumOddNumberArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int abs = array[i];
        if(abs < 0)
        {
            abs = abs * -1;
        }

        if(abs % 2 == 1)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

Console.Clear();
int[] randomArray = fillArrayNumber(5, -10, 10);
printArray(randomArray);
int result = sumOddNumberArray(randomArray);
Console.WriteLine($"Сумма всех нечетных элементов массива равна {result}");