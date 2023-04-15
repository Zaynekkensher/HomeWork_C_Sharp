int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int n = EnterData("Введите значение: ");

for (int i = 1; i <= n; i++)
{
    Console.Write($"{i*i}<=, ");
}