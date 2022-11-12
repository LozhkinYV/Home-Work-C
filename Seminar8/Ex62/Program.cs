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


/*void FillImage(int[,] array, int r, int co, int k)
{
     
    if (r >= array.GetLength(0)) r--;
    if (co >= array.GetLength(1)) co--;
    if (r < 0) r++;
    if (co < 0) co++;
    if (array[r, co] == -1)
    {
        array[r, co] += k;
        k++;
        FillImage(array, r, co + 1, k);
        FillImage(array, r + 1, co, k);
        FillImage(array, r, co - 1, k);
        FillImage(array, r - 1, co, k);
    }

}*/

int[,] FillMatrixSpiral(int[,] array)
{
    int k = 2; //заполнение массива
    int r = 0; //позиция строки
    int col = 0; //позиция столбца
    int a = array.GetLength(1); // счетчик для движения вправо
    int b = array.GetLength(0); // счетчик для движения вниз
    int c = 0; // счетчик для движения вверх
    int d = 0; // счетчик для движения влево
   
for (int l=0; l<array.GetLength(1)/2; l++)
{
    for (int i = col; i < a; i++)
    {
        if (array[r, col] == -1)
        {
            array[r, col]  += k;
            k++;

        }
        col++;
    }
    col--;

    for (int m = r; m < b; m++)
    {
        if (array[r, col] == -1)
        {
            array[r, col] += k;
            k++;

        }
        r++;
    }
    r--;

    for (int j = col; j >= c; j--)
    {
        if (array[r, col] == -1)
        {
            array[r, col] += k;
            k++;

        }
        col--;
    }
    col++;
    for (int n = r; n > d; n--)
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
    if (array.GetLength(1)%2!=0)
    {
     array[r, col+1] += k;
    }
}

    return array;
}




int row = Input("Введите количество строк и столбцов: ");
int column = row;
//int rowMatrix = 0;
//int columnMatrix = 0;
//int kk = 2;

Console.WriteLine();

int[,] array = new int[row, column];
FillArray(array);
PrintArray(array);
Console.WriteLine();
//FillImage(array, rowMatrix, columnMatrix, kk);
FillMatrixSpiral(array);
PrintArray(array);




