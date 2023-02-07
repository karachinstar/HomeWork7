/*Задача 50. 
Напишите программу, которая на вход принимает позиции элемента в 
двумерном массиве, и возвращает значение этого элемента или же указание, 
что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/
Console.Write("Введите длину массива = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение рандомного числа = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение рандомного числа = ");
int max = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число, которое необходмо искать = ");
int k = Convert.ToInt32(Console.ReadLine());
int l = 0;
int [,] num = new int[m, n];
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
   
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        if (num[i, j] == k)
        {
            l++;
        }
    }
    
}
if (l > 0)
{
    Console.WriteLine($"В массиве есть число {k}");
}
else
{
    Console.WriteLine($"В массиве нет числа {k}");
}