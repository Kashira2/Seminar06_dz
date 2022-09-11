Console.WriteLine("Введите значение первой прямой k1 : ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение первой прямой b1 : ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение второй прямой k2 : ");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение второй прямой b2 : ");
double b2 = double.Parse(Console.ReadLine());

// y = k1 * x + b1
// y = k2 * x + b2
// k2*x + b2 == k1*x + b1

// (k2*x)-(k1*x) + b2 == b1 
// (k2 - k1) *x == b1 - b2
// x == (b1 - b2) / (k2 - k1)
void SearchDot(double k1, double b1, double k2, double b2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k1 * x + b1;
    if ( k1 == k2 && b1 == b2) Console.WriteLine($"две прямые совпадают");
    else if (k2*x + b2 != k1*x + b1) Console.WriteLine($"две прямые параллельны и не имеют точек пересечения");
    else Console.WriteLine($"Точка пересечения двух прямых: ({x},{y})");
}
SearchDot(k1,b1,k2,b2);