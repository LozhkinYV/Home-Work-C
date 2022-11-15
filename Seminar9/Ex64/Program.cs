/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
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

 string Nambers (int n)
{
       if (n<1)
    {
        return string.Empty;
    }
    else 
    {
        return $"{n},{Nambers (n-1)}";
        
    }
}



int N = Input("Введите целое число: ");
Console.Write($"\"");
Console.Write((Nambers(N)).TrimEnd(','));
Console.Write($"\"");