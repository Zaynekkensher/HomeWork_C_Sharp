//Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат
//точек в этой четверти (x и y).

int EnterData(string text)
{
    Console.WriteLine(text);
    return (int.Parse(Console.ReadLine()));
}


int chetvr = EnterData("Введите значение четверти: ");

if (chetvr == 1)
{
    Console.WriteLine("В первой четверти - x > 0 y > 0");
}

if (chetvr == 2)
{
    Console.WriteLine("Во второй четверти - x < 0 y > 0");
}

if (chetvr == 3)
{
    Console.WriteLine("В третьей четверти - x < 0 y < 0");
}
if (chetvr == 3)
{
    Console.WriteLine("В четвертой четверти - x > 0 y < 0");
}



// a = int(input('Введите номер четверти в которой бы хотели узнать диапозон возможных координат: '));

// if a == 1:
//     EnterData('В первой четверти - x > 0 y > 0');
// elif a == 2:
//     EnterData('Во второй четверти - x < 0 y > 0');
// elif a == 3:
//     EnterData('В третьей четверти - x < 0 y < 0');
// elif a == 4:
//     EnterData('В четвертой четверти - x > 0 y < 0');
// else:
//     EnterData('Такой четверти нет :(');