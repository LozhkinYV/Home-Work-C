while (true)
{
Console.Write("Введите целое число от 1 до 7: ");
string a = Console.ReadLine();


if (long.TryParse(a, out long number))
{
    long b = long.Parse(a);
    if (b >= 1 && b < 6)
    {
        Console.WriteLine("Нет, не выходной");
    }
        else
        {
            if (b == 6 ||b ==7)
            {
                Console.WriteLine("Да, выходной");
            }
                else
                {
                    Console.WriteLine("Вы ввели числа не в интервале от 1 до 7!");
                }
    
        }
    break;
}
    else 
    {
        Console.WriteLine("Это не целое число!");
        break;
    }
}
