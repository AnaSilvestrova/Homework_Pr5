/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

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

int FindSumOddPos(int [] array)
{
    int sumOddPos = 0;
    for (int i = 0; i < array.Length; i++)
    {
       if(i % 2 == 1)
       {
        sumOddPos += array[i];
        i++;
       }
       else
       {
        sumOddPos += 0;
       }
    }
    return sumOddPos;  
}

int [] array = CreateArray(4, -100, 100);
Console.WriteLine($"[{PrintArray(array)}]");

int result = FindSumOddPos(array);
Console.WriteLine($"The sum of elements of array in odd positions is {result}.");