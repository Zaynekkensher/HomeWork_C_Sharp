//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

void Progressive()
{
    Console.WriteLine("Введите A");
    int numberA = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите B");
    int numberB = Convert.ToInt32(Console.ReadLine());
    double result = numberA;
   for(int i=1; i<= numberB;i++)
   {
       result = Math.Pow(result, numberB);
       Console.WriteLine(result);
   }
//   Console.WriteLine(result);
}
Progressive();
