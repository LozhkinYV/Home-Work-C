Console.Write("Введите число: ");
string N11 = Console.ReadLine();
int N = int.Parse(N11);
int cout = 2;

if (N >= cout)
{
    while (cout < N-1)
    {
       Console.Write(cout); 
       Console.Write(", ");
       cout = cout+2;
    }
    Console.Write(cout); // это нужно чтобы не выводило последнюю запятую
}
else 
{
    Console.Write("Задайте промежуток больше 1");
}
