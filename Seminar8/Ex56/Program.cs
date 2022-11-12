/*
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
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

int[] SumRowArray(int[,] array, int[] summ) //создание одномерного массива из суммы строк двумерного
{
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            summ[row] += array[row, column];
        }

    }
    return summ;
}

void PrintSumRowArray(int[] array) //вывод суммы строк для самопроверки
{
    for (int row = 0; row < array.Length; row++)
    {
        Console.WriteLine($"{array[row]}");
    }
}

void RowArrayMin(int[] array) //поиск и вывод наименьшей строки с наименьшей суммой
{
    int index = 0;
    for (int row = 1; row < array.Length; row++)
    {
        if (array[row] < array[index])
        {
            index = row;
        }
    }
    Console.Write($"Наименьшая сумма в {index + 1} строке");
}

int row = Input("Введите количество строк: ");
int column = Input("Введите количество столбцов: ")
int[,] array = new int[row, column];
int[] summ = new int[array.GetLength(0)];

Console.WriteLine();

FillArray(array);
PrintArray(array);
Console.WriteLine();

SumRowArray(array, summ);
PrintSumRowArray(summ);
Console.WriteLine();

RowArrayMin(summ);
