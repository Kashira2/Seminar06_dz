Console.WriteLine("Введите значния трех сторон треугольника.");
Console.WriteLine("Первая сторона: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Второая сторона: ");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Третья сторона: ");
double c = double.Parse(Console.ReadLine());

if (a < (b+c) && b < (a+c) && c < (b+a))
{
    Console.WriteLine("треугольник существует");
}
else Console.WriteLine("треугольник не существует");

double Perimeter (double a, double b, double c)
{
    double
 result = a + b + c;
    return result;
}

double Square (double a, double b, double c, double perimetr)
{
    double p = perimetr / 2;
    double S = Math.Sqrt(p*(p - a)*(p - b)*(p - c));
    return S;
}

void Corner (double a, double b, double c)
{
    double CornerA = Math.Acos((b*b+c*c-a*a)/(2*b*c))*180/Math.PI;
    double CornerB = Math.Acos((a*a+c*c-b*b)/(2*a*c))*180/Math.PI;
    double CornerC = Math.Acos((b*b+a*a-c*c)/(2*b*a))*180/Math.PI;
    Console.WriteLine($"Угол A = {CornerA} градусов");
    Console.WriteLine($"Угол B = {CornerB} градусов");
    Console.WriteLine($"Угол C = {CornerC} градусов");

    if (CornerA == 90 || CornerB == 90 || CornerC == 90 ) Console.WriteLine($"Данный треугольник является прямоугольным");
}

void TypeTriangle(double a, double b, double c)
{
    if ( a == b || a == c || b == c ) Console.WriteLine($"Данный треугольник является равнобедренным");
    if ( a == b && a == c && b == c ) Console.WriteLine($"Данный треугольник является равносторонним");
}


Console.WriteLine($"Периметр данного треугольника = {Perimeter(a,b,c)}");

Console.WriteLine($"Площадь данного треугольника = {Square(a,b,c, Perimeter(a,b,c))}");

TypeTriangle(a,b,c);

Corner(a,b,c);

