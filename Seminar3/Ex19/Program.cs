string Print(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
    value = value.Replace(" ", "");
	return value;
}

string Reverse(string massege)
{
    char[] rev = massege.ToCharArray();
    Array.Reverse(rev);
    string value = new string(rev);
	return value;
}

string a = Print ("Введите число или слово: ");
string b = Reverse (a);

if (a.ToLower() == b.ToLower()) {Console.WriteLine("Палиндром"); }
else {Console.WriteLine("Не палиндром!");}


