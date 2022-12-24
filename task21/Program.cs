// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
 //  X1,Y1,Z1   X2,Y2,Z2
// A (3,6,8); B (2,1,-7), -> 15.84 
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите кординаты X1:");
int X1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты X2:");
int X2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты Y1:");
int Y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты Y2:");
int Y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты Z1:");
int Z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кординаты Z2:");
int Z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Round(Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2) + Math.Pow(Z1 - Z2, 2)), 2);
Console.WriteLine(distance);
