//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int SummDigits (string number)
{     
   int summ = 0;
   
   for(int i=0;i < number.Length; i++)
   {
       summ = summ + Convert.ToInt32(Char.GetNumericValue(number[i]));
   }
   return summ;
}

Console.WriteLine("Enter number...");
int SumNumber = SummDigits(Console.ReadLine());
Console.WriteLine($"Summ of digits of this number is {SumNumber}");