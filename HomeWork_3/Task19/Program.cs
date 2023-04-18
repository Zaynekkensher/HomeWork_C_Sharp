int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}

int r,sum=0,t;

int num = EnterData("Введите значение: ");

if (num > 9999 && num < 100000)
{
for(t=num; num!=0; num = num/10)
{
r = num % 10;
sum = sum*10+r;
}
if(t == sum)
Console.Write($"{t} является палиндромом.");
else
Console.Write($"{t} не является палиндромом.");
} else
Console.Write("Введите пятизначное число!");