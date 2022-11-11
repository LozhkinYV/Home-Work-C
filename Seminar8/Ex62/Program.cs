/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
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

int[,] FillArray(int[,] array) //создание рандомного двумерного массива
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            array[row, column] = -1;
        }

    }
    return array;
}

void PrintArray(int[,] array) //вывод двумерного массива
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            Console.Write($"{array[row, column]} ");
        }
        Console.WriteLine();
    }
}

void FillImage(int[,] array, int r, int co, int k)
{
    if (r >= array.GetLength(0)) r--;
    if (co >= array.GetLength(1)) co--;
    if (r < 0) r++;
    if (co < 0) co++;
    if (array[r, co] == -1)
    {
        array[r, co] += k;
        k++;
        if (co==0)
        FillImage(array, r, co + 1, k);
        if (co==array.GetLength(1))
        FillImage(array, r + 1, co, k);
        if (r==0)
        FillImage(array, r, co - 1, k);
        if (r==0)
        FillImage(array, r - 1, co, k);
    }
}

int row = Input("Введите количество строк и столбцов: ");
int column = row;
int rowMatrix = 0;
int columnMatrix = 0;
int kk = 2;

Console.WriteLine();

int[,] array = new int[row, column];
FillArray(array);
PrintArray(array);
Console.WriteLine();
FillImage(array, rowMatrix, columnMatrix, kk);
PrintArray(array);




