// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using static System.Console;
 Clear();
 Write ("Введите координату Х первой точки:");
 double x1=Convert.ToInt32(ReadLine());
 Write ("Введите координату Y первой точки:");
 double y1=Convert.ToInt32(ReadLine());
 Write ("Введите координату Z первой точки:");
 double z1=Convert.ToInt32(ReadLine());
 Write ("Введите координату X второй точки:");
 double x2=Convert.ToInt32(ReadLine());
 Write ("Введите координату Y второй точки:");
 double y2=Convert.ToInt32(ReadLine());
 Write ("Введите координату Z второй точки:");
 double z2=Convert.ToInt32(ReadLine());
double distance=Math.Sqrt(Math.Pow (x1-x2,2)+Math.Pow(y1-y2,2)+ Math.Pow (z1-z2,2));

Write($"Расстояние между двумя точками в 3D пространстве {distance:f2}");
