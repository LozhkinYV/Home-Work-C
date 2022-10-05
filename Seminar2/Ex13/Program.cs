Console.Write("Введите число: ");
string a = Console.ReadLine();
int b = a.Length;

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