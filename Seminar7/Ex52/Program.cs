/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
(Округление до 2х знаков - Math.Round(value, 2))
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

int[,] FillArray2(int[,] array, int val1, int val2) //создание рандомного двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = new Random().Next(val1, val2);
        }

    }
    return array;
}

void PrintArray2(int[,] array) //вывод двумерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Average(int[,] array)
{
    int[] summ = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            summ[i] += array[j, i];
        }
    }

   for (int k = 0; k < summ.Length; k++)
    {
        Console.Write($"{Math.Round(summ[k] * 1.0 / array.GetLength(0), 1)}|");
    }
}

int min = 1; // значения массива от
int max = 10;  // значения массива до

int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");
Console.WriteLine();

int[,] array2 = new int[m, n];
FillArray2(array2, min, max);
PrintArray2(array2);

Console.WriteLine();

Average(array2);