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

void EvenNumbers(int val1, int val2, int val3)
{
    int[] arr = RandomArray(val1, val2, val3);
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
}

int len = Input("Введите длину массива: "); // длина массива
int minCol = 100; // минимальное значение массива
int maxCol = 1000; // максимальное значение массива

EvenNumbers(len, minCol, maxCol);