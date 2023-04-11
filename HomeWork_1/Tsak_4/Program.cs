//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

 double Number1 = new Random().Next(100); 
 Console.WriteLine("Случайное число №1: " + Number1); 
 double Number2 = new Random().Next(100); 
 Console.WriteLine("Случайное число №2: " + Number2); 
 double Number3 = new Random().Next(100); 
 Console.WriteLine("Случайное число №3: " + Number3); 
 double MaxNumber = Number1; 

 if (Number2 > MaxNumber) 
 { 
     MaxNumber = Number2; 
 } 
 if (Number3 > MaxNumber) 
 { 
     MaxNumber = Number3; 
 } 
 Console.Write("Из перпечисленных выше числе, максимальное является: " + MaxNumber);