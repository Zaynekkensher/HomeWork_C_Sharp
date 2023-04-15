// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние 
// между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int x1 = EnterData("Введите значение x1: ");
int x2 = EnterData("Введите значение x2: ");
int y1 = EnterData("Введите значение y1: ");
int y2 = EnterData("Введите значение y2: ");

double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

Console.WriteLine($"{distance}");