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
        array[i] = rand.Next(min, max+1);
    }
    return array;
}

string PrintArray(int [] array) // Метод для печати массива.
{
    return string.Join(", ", array);
}

int CheckArrayElements(int [] array) // Проверка на четность.
{
    int count = 0;
    foreach(int el in array)
    {
       count += (el % 2 == 0) ? 1 : 0;
    }
    return count;
}

int [] array = CreateArray(4, 100, 999); // Диапазон положительных трехзначных чисел. 
Console.WriteLine($"[{PrintArray(array)}]");

int result = CheckArrayElements(array);
Console.WriteLine($"This array contains {result} of even numbers.");