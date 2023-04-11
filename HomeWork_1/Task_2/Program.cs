//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

 Console.Write("Введите первое число: "); 
 int Number1 = int.Parse(Console.ReadLine()); 
 Console.Write("Введите второе число: "); 
 int Number2 = int.Parse(Console.ReadLine()); 
 int max = 0;

 if (Number1 > Number2)
 {
    Console.WriteLine("Число " + Number1 + " больше числа " + Number2);
 }
 else
 {
    Console.WriteLine("Число " + Number2 + " больше числа " + Number1);
 }