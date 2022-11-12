/*
Напишите программу, которая задаёт массив из N элементов и выводит их на экран.
(на входе N- длина массива, min и max- ограничения для значений элементов массива, которые лежат в [min, max])
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

void MyArray(int[] val, int min, int max) // создает рандомные массивы 
{    
    int length = val.Length;
    int index = 0;
    while (index < length)
    {
        val[index] = new Random().Next(min, max); 
        index++;
    }
    val[0] = min;
    val[length-1] = max;
}

void PrintArray(int[] col) // печатает массив 
{
    int count = col.Length;
    int position = 0;
    Console.Write("[");
    while (position < count-1)
    {
        Console.Write(col[position]);
        Console.Write(", ");
        position++;
    }
    Console.Write(col[position]);
    Console.Write("]");
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

bool Valid(int val) 
{
    if (val < 0) return false;
    else return true;
}

int N = Input("Введите длину массива: ");
int min = Input("Введите min ограничение: ");
int max = Input("Введите max ограничение: ");

if (Valid(N)){
int[] array = new int[N];
 MyArray(array, min, max);
 PrintArray(array);
}
else
{
   Console.WriteLine("Возможно вы ввели отрицательную длину массива!");  
}