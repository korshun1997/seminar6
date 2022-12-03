// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.WriteLine("Введите k1, b1, k2, b2");
int k1 = Convert.ToInt32(Console.ReadLine()); 
int b1 = Convert.ToInt32(Console.ReadLine());
int k2 = Convert.ToInt32(Console.ReadLine());
int b2 = Convert.ToInt32(Console.ReadLine());
int x = 0;
int y1 = k1*x+b1;
int y2 = k2*x+b2;
double x0 = 0;
double y0 = 0;
double Point(int k1, int b1, int k2, int b2, double x0, double y0)
{
    x0 = (b2-b1)/(k1-k2);
    return x0;
}
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
}
else
{
    Point(k1, b1, k2, b2, x0, y0);
    y0 = k2*x0+b2; 
    Console.WriteLine($"{x0}; {y0}");
}
