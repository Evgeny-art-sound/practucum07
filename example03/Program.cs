// Написать программу, которая в двумерном массиве заменяет строки на столбцы или 
// сообщить, что это невозможно (в случае, если матрица не квадратная)
Console.Clear();
void FillArray(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    Random rnd = new Random();
    for (int i = 0; i < rowsLength; i++)
    {
        for (int j = 0; j < columnsLength; j++)
        array[i,j]= rnd.Next(-100,100);
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

void RowsColumnsReverse(int[,] array)
{
    int rowsLength = array.GetLength(0);
    int columnsLength = array.GetLength(1);
    int temp = 0;
    int b = -1;
    for (int j = 0; j < columnsLength; j++)
    {
        b++;
        for (int i = 0 + b; i < columnsLength; i++)
        {
            temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    Console.WriteLine("Поменяем местами столбцы и строки ");
    PrintArray(array);
}
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine() ?? "");
int[,] array = new int[rows, columns];
FillArray(array);
PrintArray(array);
if (rows != columns)
    Console.WriteLine("Замена не возможна: матрица не квадратная");
else
   RowsColumnsReverse(array);