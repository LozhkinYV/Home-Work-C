/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int Input(string massege) // ввод целочисленных данных
{
    while (true)
    {
        Console.Write(massege);
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

int Nambers(int m, int n)
{
    if (n < m)
    {
        return 0;
    }
    else
    {
        return Nambers((m + 1), n) + m;

    }
}



int M = Input("Введите натуральное число N= ");
int N = Input("Введите натуральное число большее предыдущего M= ");
if (M > N || N < 1 || M < 1)
{
    Console.Write($"Вы ввели некорректные данные. Попробуйте еще раз.");
}
else
{
    Console.Write($"\"");
    Console.Write(Nambers(M, N));
    Console.Write($"\"");
}