using System;


System.Console.Write("Doira radiusini kiriting: ");
double radius = Convert.ToDouble(Console.ReadLine());

double doiraYuzi = Math.PI * Math.Pow(radius, 2);
double aylanaUzunligi = 2 * Math.PI * radius;

System.Console.WriteLine($"S={doiraYuzi}, L={aylanaUzunligi}");


