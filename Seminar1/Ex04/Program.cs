Console.Write("Введите число1: ");
string N11 = Console.ReadLine();
int  N1 = int.Parse(N11);
Console.Write("Введите число2: ");
string N22 = Console.ReadLine();
int  N2 = int.Parse(N22);
Console.Write("Введите число3: ");
string N33 = Console.ReadLine();
int  N3 = int.Parse(N33);
int max = N1;

if (N2 > max) max = N2;
if (N3 > max) max = N3;
Console.Write("max = ");
Console.WriteLine(max);
