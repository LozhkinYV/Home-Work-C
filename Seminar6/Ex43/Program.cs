/*
 Напишите программу, которая найдёт точку пересечения двух прямых, 
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double Input(string massege) 
{
    while (true)
    {
        Console.WriteLine(massege);
        string value = Console.ReadLine();
        if (double.TryParse(value, out double resalt))
        {
            return resalt;
            break;
        }
        else
        {
            Console.WriteLine("Это не число! Попробуйте еще раз!");
        }
    }
}

void DotXY (double b1, double k1, double b2, double k2)
{
    if (b1==b2 && k1==k2)
    {
        Console.WriteLine($"Прямые совпадают! Множество решений "); 
        
    } else
    {
        if (Valid (b1, k1, b2, k2))
        {
            double x = (b2-b1)/(k1-k2);
            double y = k1 * x + b1;
            Console.WriteLine($"({Math.Round(x,2)} ; {Math.Round(y,1)})");
        } else
        {
           Console.WriteLine($"Прямые параллельны! Нет точки пересечения");  
        }
       
    }

}

bool Valid (double val1, double val2, double val3, double val4)
{
    if (val1/val3 == val2/val4 || (val2-val4) == 0)
    {
        return false;
    }
    else 
    {
        return true;
    }

}

double b1 = Input("Введите b1");
double k1 = Input("Введите k1");
double b2 = Input("Введите b2");
double k2 = Input("Введите k2");

 DotXY (b1, k1, b2, k2);
