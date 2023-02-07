/*Задача 47.
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/


double Massiv(int m, int n, int min, int max)
{
    double[,] num = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < num.GetLength(0); i++)
    {
        for (int j = 0; j < num.GetLength(1); j++)
        {
            num[i, j] = rand.Next(min, max) + rand.NextDouble(); ;
            Console.Write($"{Math.Round(num[i, j], 1)} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return num[m, n];
}
Console.Write("Введите длину массива = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите ширину массива = ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение рандомного числа = ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение рандомного числа = ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Massiv(m, n, min, max));
//я не понимаю, что за ошибку выдает в конце, все выводит
//но видимо метод неправильно прописал