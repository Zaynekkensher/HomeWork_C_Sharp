// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

 int number = new Random().Next(100, 1000);
 Console.WriteLine(number);

 int number1 = number / 10;
 int number2 = number1 % 10;

 Console.WriteLine(number2);
