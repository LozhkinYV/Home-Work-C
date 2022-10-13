double Print(string massege)
{
	Console.WriteLine(massege);
	double value = Convert.ToDouble(Console.ReadLine());
	return value;
}

double Square(double val1, double val2)
{
	double resalt = Math.Pow (val1 - val2, 2); 
	return resalt;
}

double xA = Print("Введите координату xA: ");
double yA = Print("Введите координату yA: ");
double zA = Print("Введите координату zA: ");

double xB = Print("Введите координату xB: ");
double yB = Print("Введите координату yB: ");
double zB = Print("Введите координату zB: ");

double X = Square(xA, xB);
double Y = Square(yA, yB);
double Z = Square(zA, zB);

double l = Math.Sqrt(X + Y + Z) ;

Console.WriteLine("Расстояние АВ = " +l);


