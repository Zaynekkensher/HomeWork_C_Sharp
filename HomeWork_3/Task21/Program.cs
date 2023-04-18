// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


// Функция ввода сообщения
int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int x1 = EnterData("Введите координату X первой точки: ");
int y1 = EnterData("Введите координату Y первой точки: ");
int z1 = EnterData("Введите координату Z первой точки: ");
int x2 = EnterData("Введите координату X второй точки: ");
int y2 = EnterData("Введите координату Y второй точки: ");
int z2 = EnterData("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Длинна отрезка {length}");

