/*Задача 34:
Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();
Console.WriteLine("\n Задача 34");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    return array;
}

int[] array = GetArray(4, 111, 999);

int FindingEvenNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 1)
        {
            count++;
        }
    }
    return count;
}
Console.Write($" -> {FindingEvenNumber(array)}");