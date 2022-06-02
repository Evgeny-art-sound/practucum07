using System.Data;
using System.Data.Common;
// Написать программу, которая обменивает элементы первой строки и последней строки
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
            array[i, j] = new Random().Next(-1000, 1000);
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
            Console.Write($"{array[i, j]}   ");
        Console.WriteLine($"");


    }
}

void ArrayChange(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    int i = 0;
    for (int j = 0; j < columnsLength; j++)
    {
        int temp = array[i, j];
        //Console.Write($"! {temp}  !");
        array[i, j] = array[rowsLength - 1, j];
        array[rowsLength - 1, j] = temp;
    }

}

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
ArrayChange(array);
Console.WriteLine($" Массив после замены строк местами: ");

Console.WriteLine();
PrintArray(array);