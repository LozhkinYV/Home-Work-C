/*
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
Console.WriteLine("Введите числа через запятую: ");
string text = Console.ReadLine();
string[] value= text.Split(',');
int s=0; 
bool cas=true;
for (int i=0; i<value.Length; i++)
{
    if (int.TryParse(value[i], out int resalt))
    {
    if (resalt<=0) {}
    else {s++;}
} else 
{
    Console.WriteLine("Не корректно введы данные!");
    cas = false;
    break;
}
}

if (cas)
{
    Console.WriteLine(s);
}
else {}