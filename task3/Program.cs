﻿int[,] GetArray(int m, int n, int minValue, int maxValue) // создает двумерный массив
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
    
}

void PrintArray(int[,] inArray) // вывводит двумерный массив
{
    for (int row = 0; row < inArray.GetLength(0); row++)
    {
        for (int column = 0; column < inArray.GetLength(1); column++)
        {
            Console.Write($"{inArray[row,column]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк массива: ");
int rows=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns=Convert.ToInt32(Console.ReadLine());

int[,] array = GetArray(rows, columns, 0, 9);
PrintArray(array);


for (int column = 0; column < array.GetLength(0); column++)
{
double sum = 0;
        for (int row = 0; row < array.GetLength(1); row++)
        {
            sum = sum + array[row,column];
        }
        Console.WriteLine($"{sum/rows:f1}");
}
    
        
