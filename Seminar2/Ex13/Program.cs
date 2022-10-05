while (true)
{
Console.Write("Введите число: ");
string a = Console.ReadLine();
int b = a.Length;

if (double.TryParse(a, out double number))
    {
        if (a[0] != '-' && b > 2)
{
    Console.WriteLine(a[2]); 
} 
else 
{
    if (a[0] == '-' && b > 3)
    {
        Console.WriteLine(a[3]);
    }    
        else 
        {
            Console.WriteLine("Третьей цифры нет");
            }
}
        
        break;
    }
    Console.WriteLine("Не удалось распознать число, попробуйте еще раз.");
}

