/*
Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int len = Input("Введите длину массива: ");
int minCol = 100; // минимальное значение массива
int maxCol = 1000; // длина массива

int[] arr = RandomArray(len, minCol, maxCol);
int s = 0;
int a=0;
for (int i=0; i < arr.Length; i++)
{
    a = arr[i]%2;
    if (a == 0) 
    {
        s++;
    }
    else {}
}
Console.WriteLine($"Количество четных {s}");
