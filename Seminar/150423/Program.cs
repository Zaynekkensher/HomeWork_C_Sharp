int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int x = EnterData("Введите значение x: ");
int y = EnterData("Введите значение y: ");

if (x>0 & y>0)
{
    Console.WriteLine("1");
}
if (x<0 & y>0)
{
    Console.WriteLine("2");
}
if (x<0 & y<0)
{
    Console.WriteLine("3");
}
if (x>0 & y<0)
{
    Console.WriteLine("4");
}
