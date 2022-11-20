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
    else
    {
        Console.WriteLine("Треугольник не существует");
    }
}
void perimeterAreaTriangle(double a, double b, double c)
{
    if (a + b > c && a + c > b && b + c > a){
    double P = a + b + c;
    Console.WriteLine("Периметр = " + P);
    double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
    Console.WriteLine( "Площадь = " + S.ToString("0.##"));}
}

void anglesTriangle(double a, double b, double c)
{

    if (a + b > c && a + c > b && b + c > a){
    double A = (Math.Acos((a * a + b * b - c * c) / (2 * a * b)))*(180.0/Math.PI);
    double B = (Math.Acos((c * c + b * b - a * a) / (2 * c * b)))*(180.0/Math.PI);
    double C = (Math.Acos((a * a + c * c - b * b) / (2 * a * c)))*(180.0/Math.PI);
    Console.WriteLine("Угол A=" + A.ToString("0") + "°");
    Console.WriteLine("Угол B=" + B.ToString("0") + "°");
    Console.WriteLine("Угол C=" + C.ToString("0") + "°");
    }
}
checkTriangle(a, b, c);
perimeterAreaTriangle(a, b, c);
anglesTriangle(a, b, c);
