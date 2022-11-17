/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
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
    if (m == 0)
    {
        return n + 1;
    }
    {
        if (m > 0 && n == 0)
        {
            return Nambers(m - 1, 1);
        }
        else
        {
            if (m > 0 && n > 0)
            {
                return Nambers((m - 1), Nambers(m, n - 1));
            }
            else
            {
                return 0;
            }
        }
    }
}

int M = Input("Введите натуральное число M = ");
int N = Input("Введите натуральное число N = ");

if (M >= 0 && N >= 0)
{
    Console.WriteLine(Nambers(M, N));
}
else
{
    Console.WriteLine($"Вы ввели некорректные данные. Попробуйте еще раз.");
}
