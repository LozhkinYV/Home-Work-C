string Print(string massege)
{
	Console.Write(massege);
	string value = Console.ReadLine();
    value = value.Replace(" ", "");
	return value;
}

string a = Print ("Введите число или слово: ");

char[] rev = a.ToCharArray();
Array.Reverse(rev);
string b = new string(rev);



if (a.ToLower() == b.ToLower()) {Console.WriteLine("Палиндром"); }
else {Console.WriteLine("Не палиндром!");}


