// В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.Clear();
void FillArray(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    Random rnd = new Random();
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
            array[i, j] = rnd.Next(-1000, 1000);
    }
}
void PrintArray(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
            Console.Write($"{array[i, j]}   ");
        Console.WriteLine($"");


    }
}
void MinRowsSum(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    int minRowsIndex = 0;
    int temp = 0;
    for (int i = 0; i < rowsLength; i++)
    {
        int rowsSum = 0;
        for (int j = 0; j < columnsLength; j++)
        {
            rowsSum = rowsSum + array[i, j];
            if (temp == 0)
                temp = rowsSum;
            if (temp > rowsSum)
            {
                temp = rowsSum;
                minRowsIndex = i;
            }
        }
        Console.WriteLine($"Промежуточная сумма {i} строки  {rowsSum}  ");
    }
    Console.WriteLine($"Индекс строки с минимальной суммой элементов: {minRowsIndex}");
}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[rows, columns];
FillArray(array);
Console.WriteLine();

PrintArray(array);
MinRowsSum(array);
