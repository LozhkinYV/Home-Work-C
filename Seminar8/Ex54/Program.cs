/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

            array[row, column] = new Random().Next(1, 10);
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

int[,] SortRowArray(int[,] array) //Сортировка двумерного массива
{

    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[row, k] < array[row, column])
                {
                    int temp = array[row, k];
                    array[row, k] = array[row, column];
                    array[row, column] = temp;
                }
            }
        }

    }
    return array;
}

int row = Input("Введите количество строк: ");
int column = Input("Введите количество столбцов: ");
Console.WriteLine();

int[,] array = new int[row, column];
FillArray(array);
PrintArray(array);

Console.WriteLine();

SortRowArray(array);
PrintArray(array);