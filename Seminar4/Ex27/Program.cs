/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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

bool Valid(int val)
{
    if (val < 0) return false;
    else return true;
}

void Sum(int val)
{
   if (Valid(val))
    { 
        int sum =0;
        while (val>0)
        {
        sum = sum + val%10;
        val= val/10;
        }
        Console.Write($"Сумма цифр числа = {sum}");
    }
    else
    {
        Console.Write("Не корректные данные!");
    }
}


int A = Input("Введите число A: ");
Sum(A);


