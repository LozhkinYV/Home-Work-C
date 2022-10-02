Console.Write("Введите число1: ");
string N11 = Console.ReadLine();
int  N1 = int.Parse(N11);
Console.Write("Введите число2: ");
string N22 = Console.ReadLine();
int  N2 = int.Parse(N22);

if (N1 > N2) 
{
    Console.Write("max = ");
    Console.Write(N1);
    Console.Write(", ");
    Console.Write("min = ");
    Console.WriteLine(N2);
}
else 
{
    Console.Write("max = ");
    Console.Write(N2);
    Console.Write(", ");
    Console.Write("min = ");
    Console.WriteLine(N1);
}
