// Написать программу, упорядочивания по убыванию элементы каждой строки двумерного массива.
Console.Clear();

void FillArray(int[,] array)
{
    Random rnd = new Random();
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        {
            array[i, j] = new Random().Next(-10000, 10000);

        }
    }
}
void PrintArray(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();

    }
}
void SortArray (int[,]array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    for (int j = 0; j < rowsLength; j++)
        for (int i = 0; i < rowsLength; i++)
            for (int b = 0; b < columnsLength - i - 1; b++)
                if (array[j, b] < array[j, b + 1])
                {
                    int temp = array[j, b];
                    array[j, b] = array[j, b + 1];
                    array[j, b + 1] = temp;
                }
}
Console.Write("Ведите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[rows, columns];


FillArray(array);
Console.WriteLine($"Массив до сортировки: ");
PrintArray(array);
SortArray(array);
Console.WriteLine($"Массив после сортировки: ");
PrintArray(array);