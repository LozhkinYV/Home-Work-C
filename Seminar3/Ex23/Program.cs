int Input(string massege)
{
    Console.WriteLine(massege);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int InDegree(int val1, int val2)
{
    double value = Math.Pow(val1, val2);
    int resalt = Convert.ToInt32(value);
    return resalt;
}

int A = Input("Введите число A: ");
int N = Input("Введите степень N: ");

int count = 1;
while (count <= A)
    {
        Console.Write(InDegree(count, N));
        Console.Write(" ");
        count++;
    }

