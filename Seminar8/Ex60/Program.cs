/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
                                                              добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

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

int[] RandomNamber(int[] array, int minNamber, int maxNamber) //создаем массив из рандомных неповторяющихся чисел
{
    int count = 0;
    for (int i = 0; i < maxNamber - minNamber; i++)
    {
        int a = new Random().Next(minNamber, maxNamber);
        for (int j = 0; j < maxNamber - minNamber; j++)
        {
            if (a != array[j])
                count++;
            else { i--; break; }
            if (count == 90)
            {
                array[i] = a;
                count = 0;
            }
        }
    }
    return array;
}

int[,,] FillKub(int[,,] kub, int[] array) //создание рандомного 3-х мерного массива
{
    int i = 0;
    for (int width = 0; width < kub.GetLength(0); width++)
    {
        for (int height = 0; height < kub.GetLength(1); height++)
        {
            for (int depth = 0; depth < kub.GetLength(2); depth++)
            {
                kub[width, height, depth] = array[i];
                i++;
            }
        }

    }
    return kub;
}

void PrintKub(int[,,] kub) //вывод 3-х мерного массива 
{
    for (int width = 0; width < kub.GetLength(0); width++)
    {
        for (int height = 0; height < kub.GetLength(1); height++)
        {
            for (int depth = 0; depth < kub.GetLength(2); depth++)
            {
                Console.Write($"{kub[width, height, depth]}({width},{height},{depth}) ");
            }
            Console.WriteLine();
        }

    }

}



int min = 10;
int max = 100;
int a = Input("Каково ребро кубической матрицы: ");

if (Convert.ToInt32(Math.Pow(a, 3)) > max-min)
{
    Console.WriteLine("Невозможно заполнить неповторяющимися числами");
}
else 
{
int[] randomNambers = new int[max-min];
int[,,] kub = new int[a, a, a];
RandomNamber(randomNambers, min, max);
FillKub(kub, randomNambers);
PrintKub(kub);
}
