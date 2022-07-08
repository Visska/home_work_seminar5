/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
*/

void fillArrayNumber(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 20);
    }
}

void printArray(double[] array)
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

double findMaxNumberArray(double[] array)
{
    double maxNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > maxNumber)
        {
            maxNumber = array[i];
        }
    }
    return maxNumber;
}

double findMinNumberArray(double[] array)
{
    double minNumber = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNumber)
        {
            minNumber = array[i];
        }
    }
    return minNumber;
}

double[] newRandomArray = new double[5];
fillArrayNumber(newRandomArray);
printArray(newRandomArray);
double maxNumberArray = findMaxNumberArray(newRandomArray);
double minNumberArray = findMinNumberArray(newRandomArray);
double diffMaxMin = maxNumberArray - minNumberArray;
Console.WriteLine($"Разница между максимальным {maxNumberArray} и минимальным {minNumberArray} значениями массива равна {diffMaxMin}");