/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/
Console.Clear();

int [] CreateArray(int size, int min, int max) // Метод для заполнения массива случайными числами.
{
    int [] array = new int [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max+1)
    }
    return array;
}

string PrintArray(int [] array) // Метод для печати массива.
{
    return string.Join(", " array);
}

int array = CreateArray(4, 100, 999);
Console.WriteLine($"[{PrintArray(array)}]");