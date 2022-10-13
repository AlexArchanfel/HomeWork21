// Напишите программу которая принимает на вход координаты двух точек и находит расстояние между ними в 3D
Console.Clear();
double Roma(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double end;
    end = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 -y1, 2) + Math.Pow(z2 - z1, 2));
    return end;

}
Console.Write("Введите X координаты точки А: ");
int ax = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки А: ");
int ay = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты точки А: ");
int az = int.Parse(Console.ReadLine()!);

Console.Write("Введите X координаты точки B: ");
int ax2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Y координаты точки B: ");
int ay2 = int.Parse(Console.ReadLine()!);

Console.Write("Введите Z координаты точки B: ");
int az2 = int.Parse(Console.ReadLine()!);

Console.Write($"Длина равна: {Roma(ax, ay, az, ax2, ay2, az2):f2}");