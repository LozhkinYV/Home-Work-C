/*
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
(row ,colum - входные данные)
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
        for (int j = 0; j < array.GetLongLength(1); j++)
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
        for (int j = 0; j < array.GetLongLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[] InputPosition(string massege) // ввод целочисленных данных через пробел
{
    Console.WriteLine(massege);
    string val = Console.ReadLine();
    string[] value = val.Split(' ');
    int[] ar = new int[value.Length];
    for (int i = 0; i < value.Length; i++)
    {
        if (int.TryParse(value[i], out int resalt))
        {
            ar[i] = resalt;
        }
    }
    return ar;
}

void PrintPosition(int[,] arr2, int[] arr)
{
    if (arr[0] > arr2.GetLength(0)
    || arr[1] > arr2.GetLength(1)
    || arr.Length != 2)
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
    else
    {
        Console.WriteLine($"=> {arr2[arr[0] - 1, arr[1] - 1]}");
    }
}

int min = -50; // значения массива от
int max = 50;  // значения массива до

int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");
int[,] array = new int[m, n];

FillArray2(array, min, max);
PrintArray2(array);

int[] position = InputPosition("Введите позицию строки и столбца через пробел ");
PrintPosition(array, position);
