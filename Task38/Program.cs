/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Clear();
double num = 0.47899;

Console.WriteLine(Math.Round(num, 3, MidpointRounding.ToZero)); // Для округления.
*/

Console.Clear();

double [] CreateArray(int size, double min, double max) // Метод для заполнения массива случайными числами.
{
    double [] array = new double [size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble();
    }
    return array;
}

string PrintArray(double [] array) // Метод для печати массива.
{
    return string.Join(", ", array);
}

double FindMinMaxDif(double [] array)
{
    double minNum = array[0];
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < minNum)
        {
            minNum = array[i];
        }
        
        if(array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum - minNum;
}

double [] array = CreateArray(5, -10, 10);
Console.WriteLine($"[{PrintArray(array)}]");

double result = FindMinMaxDif(array);
Console.WriteLine($"The difference between max and min is {Math.Round(result, 2, MidpointRounding.ToZero)}.");
