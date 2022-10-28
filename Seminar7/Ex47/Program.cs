/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
(Округление до 2х знаков после запятой - Math.Round(value, 2))
*/

int min = -50; // значения массива от
int max = 50;  // значения массива до

int m = Input("Введите количество строк: ");
int n = Input("Введите количество столбцов: ");
double [,] array = new double [m,n];
Array2 (m, n, min, max);

void Array2(int val1, int val2, int val3, int val4)
{
for (int i = 0; i< val1; i++)
{
    for (int j=0; j<val2; j++)
    {
        
        array[i, j] = Math.Round(new Random().Next(val3, val4) + new Random().NextDouble(),1);
    }
    
}


for (int i = 0; i<val1; i++)
{
    for (int j=0; j<val2; j++)
    {
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}


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