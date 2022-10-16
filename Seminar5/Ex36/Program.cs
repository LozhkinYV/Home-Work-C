/*
Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

int[] RandomArray(int val, int min, int max) 
{
int N=val;
int[] array = new int[N];
for (int i = 0; i < N; i++)
{
     array[i] = new Random().Next(min, max+1);
}

Console.Write("[");
for (int i = 0; i < N-1; i++)
{
     Console.Write(array[i]);
     Console.Write(", ");
}
Console.Write(array[N-1]);
Console.WriteLine("]");
return array;
}

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

void SumOddPositions(int val1, int val2, int val3)
{
    int[] arr = RandomArray(val1, val2, val3);
    int s = 0;
    int a=0;
    for (int i=0; i < arr.Length; i++)
{
    a = i % 2;
    if (a == 0) 
    {  }
    else 
    {
       s = s + arr[i];
    }
}
Console.WriteLine($"Сумма в нечетных позициях {s}");
}

int len = Input("Введите длину массива: "); // длина массива
int minCol = Input("Введите минимальное значение массива: "); // минимальное значение массива
int maxCol = Input("Введите максимальное значение массива: "); // максимальное значение массива

SumOddPositions(len, minCol, maxCol);