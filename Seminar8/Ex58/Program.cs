/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int Input(string massege) // ввод целочисленных данных
{
    while (true)
    {
        Console.WriteLine(massege);
        string value = Console.ReadLine();
        if (int.TryParse(value, out int resalt))
        {
            return resalt;
            break;
        }
        else
        {
            Console.WriteLine("Это не целое число! Попробуйте еще раз!");
        }
    }
}

int[,] FillMatrix(int[,] matrix) //создание рандомного двумерного массива
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            matrix[row, column] = new Random().Next(1, 10);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix) //вывод двумерного массива
{
    for (int row = 0; row < matrix.GetLength(0); row++)
    {
        for (int column = 0; column < matrix.GetLength(1); column++)
        {
            Console.Write($"{matrix[row, column]} ");
        }
        Console.WriteLine();
    }
}

int[,] FillMatrix3(int[,] matrix1, int[,] matrix2, int[,] matrix3) //создание двумерного массива полученного из произведения двух других
{
    for (int row = 0; row < matrix1.GetLength(0); row++)
    {
        for (int column = 0; column < matrix2.GetLength(1); column++)
        {
            matrix3[row, column] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                matrix3[row, column] += matrix1[row, k] * matrix2[k, column];
            }
        }

    }
    return matrix3;
}

int row1 = Input("Введите количество строк матрицы 1: ");
int column1 = Input("Введите количество матрицы 1: ");
int row2 = Input("Введите количество строк матрицы 2: ");
int column2 = Input("Введите количество матрицы 2: ");

int[,] matrix1 = new int[row1, column1];
FillMatrix(matrix1);
PrintMatrix(matrix1);

Console.WriteLine();

int[,] matrix2 = new int[row2, column2];
FillMatrix(matrix2);
PrintMatrix(matrix2);

Console.WriteLine();

if (matrix1.GetLength(1) != matrix2.GetLength(0))
{
    Console.WriteLine("Количество столбцов матрицы 1 не равно количеству строк матрицы 2.");
}
else
{
    int[,] matrix3 = new int[row1, column2];
    FillMatrix3(matrix1, matrix2, matrix3);
    PrintMatrix(matrix3);
}
