//  Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

 Console.Clear();

 double m = EnterNumbers("Введите m: ");
 double  n = EnterNumbers("Введите n: ");
 double  temp = m;

 if (m > n) 
 {
   m = n; 
   n = temp;
 }

 PrintSumm(m, n, temp=0);

 void PrintSumm(double  m, double  n, double  summ)
 {
   summ = summ + n;
   if (n <= m)
   {
     Console.Write($"Сумма элементов= {summ} ");
     return;
   }
   PrintSumm(m, n - 1, summ);
 }

 double EnterNumbers(string enter) 
 {
   Console.Write(enter);
   double output = Convert.ToDouble(Console.ReadLine());
   return output;
 }