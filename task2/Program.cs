int[,] GetArray(int m, int n, int minValue, int maxValue) // создает двумерный массив
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

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);

Console.Write("Введите строку искомого элемента: ");
int rows2=Convert.ToInt32(Console.ReadLine());

Console.Write("Введите столбец искомого элемента: ");
int columns2=Convert.ToInt32(Console.ReadLine());

if (rows2 < rows || columns < columns2)
{
    int element = array[rows2,columns2];
    Console.WriteLine ($"Значение элемента: {element}");
}
else
{    
    Console.WriteLine ($"Такого элемента нет");
}