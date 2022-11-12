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
    int max = array[0, 0];
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
            if (array[row, column] > max)
                max = array[row, column];
    }
    for (int row = 0; row < array.GetLength(0); row++)
    {
        for (int column = 0; column < array.GetLength(1); column++)
        {
            string num = array[row, column].ToString();
            Console.Write(new String('0', max.ToString().Length - num.Length) + num + ' ');
        }
        Console.WriteLine();
    }
}

int[,] FillMatrixSpiral(int[,] array)
{
    int k = 2; //заполнение массива
    int r = 0; //позиция строки
    int col = 0; //позиция столбца
    int a = array.GetLength(1); // счетчик для движения вправо
    int b = array.GetLength(0); // счетчик для движения вниз
    int c = 0; // счетчик для движения вверх
    int d = 0; // счетчик для движения влево

    for (int l = 0; l < array.GetLength(1) / 2; l++) 
    {
        for (int i = col; i < a; i++) //пробегаем вправо и если на этом месте  -1 то заменяем ее на число
        {
            if (array[r, col] == -1)
            {
                array[r, col] += k;
                k++;

            }
            col++;
        }
        col--;

        for (int m = r; m < b; m++) //пробегаем вниз
        {
            if (array[r, col] == -1)
            {
                array[r, col] += k;
                k++;

            }
            r++;
        }
        r--;

        for (int j = col; j >= c; j--) //пробегаем влево
        {
            if (array[r, col] == -1)
            {
                array[r, col] += k;
                k++;

            }
            col--;
        }
        col++;
        for (int n = r; n > d; n--) //пробегаем вверх
        {
            if (array[r, col] == -1)
            {
                array[r, col] += k;
                k++;

            }
            r--;
        }
        r++;
        a--;
        b--;
        c++;
        d++;
        if (array.GetLength(1) % 2 != 0) 
        {
            array[r, col + 1] += k;
        }
    }

    return array;
}




int row = Input("Введите количество строк и столбцов: ");
int column = row;

Console.WriteLine();

int[,] array = new int[row, column];
FillArray(array);
PrintArray(array);
Console.WriteLine();

FillMatrixSpiral(array);
PrintArray(array);




