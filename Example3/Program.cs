// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа.
//  Определить , является ли это сторонами треугольника. 
//  Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, является ли он прямоугольным,
//   равнобедренным, равносторонним.

    Console.WriteLine("Введите сторону треугольника a:");
    double a = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону треугольника b:");
    double b = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите сторону треугольника c:");
    double c = double.Parse(Console.ReadLine());
void checkTriangle(double a, double b, double c)
{
    if (a + b > c && a + c > b && b + c > a) Console.WriteLine("Треугольник существует");
    else Console.WriteLine("Треугольник не существует");
    
}
void perimeterAreaTriangle(double a, double b, double c)
{
    double P = a + b + c;
    Console.WriteLine("Периметр = " + P);
    double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
    Console.WriteLine("{0,6:F2}","Площадь = " + S);
}

void anglesTriangle(double a, double b, double c)
{
    // cos(β)=(b²+c²−a²)÷(2×b×c); cos(γ)=(a²+c²−b²)÷(2×a×c); cos(α)=(a²+b²−c²)÷(2×a×b). 
    double A = Math.Acos((a * a + b * b - c * c) / (2 * a * b));
    double B = Math.Acos((c * c + b * b - a * a) / (2 * c * b));
    double C = Math.Acos((a * a + c * c - b * b) / (2 * a * c));
    Console.WriteLine("Угол A=" + A);
    Console.WriteLine("Угол B=" + B);
    Console.WriteLine("Угол C=" + C);
    
}
checkTriangle(a,b,c);
perimeterAreaTriangle(a,b,c);
anglesTriangle(a,b,c);
