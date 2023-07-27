// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int GetNumber(string abc)
{
    Console.Write($"{abc} ");
    int a = int.Parse(Console.ReadLine()!);
    return a;
}

void Triangle(int a, int b, int c)
{
    if (a + b >= c || a + c >= b|| b + c >= a)
Console.Write("Треугольник может существовать");
else
    Console.Write("Треугольник не может существовать");
}

int a = GetNumber("Введите сторону a:");
int b = GetNumber("Введите сторону b:");
int c = GetNumber("Введите сторону c:");

Triangle(a, b, c);