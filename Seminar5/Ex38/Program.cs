/*
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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

void SortMinMax(int val1, int val2, int val3)
{
    int[] arr = RandomArray(val1, val2, val3);
    int minimal = arr[0];
    int maximal = arr[0];
    
    for (int i=1; i < arr.Length; i++)
    {
        if (minimal > arr[i]) 
        {
           minimal = arr[i];
        }
        else if (maximal < arr[i])
        {
            maximal = arr[i];
        }
    }

Console.WriteLine($"Разность между max и min = {maximal - minimal}");
}

int len = Input("Введите длину массива: "); // длина массива
int minCol = Input("Введите минимальное значение массива: "); // минимальное значение массива
int maxCol = Input("Введите максимальное значение массива: "); // максимальное значение массива

SortMinMax(len, minCol, maxCol);