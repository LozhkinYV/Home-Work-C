/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Применять Math.Pow нельзя!
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

int Input(string massege)
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

int InDegree(int val1, int val2)
{
    int resalt = 1;
    for (int i = 1; i <= val2; i++)
    {
        resalt = resalt * val1;
    }
    return resalt;
}

bool Valid(int val1, int val2)
{
    if (val2 < 0) return false;
    else return true;
}

int A = Input("Введите число A: ");
int N = Input("Введите натуральную степень B: ");

if (Valid(A, N))
{
    Console.Write($"{A} ^ {N} = {InDegree(A, N)}");
}
else
{
    Console.Write("Не корректные данные!");
}