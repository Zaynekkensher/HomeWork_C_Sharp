
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
// */

// Функция ввода сообщения
int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int number = EnterData("Введите число N: ");

for (int i = 1; i <= number; i++)
{ 
    Console.Write($"{number} -> {(Math.Pow(i, 3))}, ");
}
