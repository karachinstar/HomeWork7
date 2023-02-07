/*Задача 52. 
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/
double average = 0;
Console.Write("Введите длину массива = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение рандомного числа = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение рандомного числа = ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[m, n];
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        num[i, j] = new Random().Next(min, max);
        Console.Write($"{num[i, j]} ");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца:");
for (int j = 0; j < num.GetLength(1); j++)
{
    for (int i = 0; i < num.GetLength(0); i++)
    {
        average+= num[i, j];
    }
    if (j < num.GetLength(1) - 1)
    {
        average = average / m;
        Console.Write($"{Math.Round(average, 1)}; ");
        average = 0;
    }
    else
    {
        average = average / m;
        Console.Write($"{Math.Round(average, 1)}.");
    }
    
}