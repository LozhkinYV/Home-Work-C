/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
                                                              добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int[,,] FillKub(int[,,] kub) //создание рандомного 3-х мерного массива depth
{
    for (int width = 0; width < kub.GetLength(0); width++)
    {
        for (int height = 0; height < kub.GetLength(1); height++)
        {
            for (int depth = 0; depth < kub.GetLength(2); depth++)
                kub[width, height, depth] = new Random().Next(10, 100);
        }

    }
    return kub;
}

void PrintKub(int[,,] kub) //вывод 3-х мерного массива depth
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


int[,,] kub = new int[2, 2, 2];
FillKub(kub);
PrintKub(kub);
