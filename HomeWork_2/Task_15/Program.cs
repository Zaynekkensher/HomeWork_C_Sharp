// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 Console.Write("Введите номер дня недели "); 
 int number = int.Parse(Console.ReadLine()); 
 if (number >= 1 && number <=5) 
 {
     Console.WriteLine("Это будний день");
 }
 else if (number==6 || number ==7)
 {
     Console.WriteLine ("Это выходной");
 }
 else 
 {
   Console.WriteLine("Введеный номер не сооветсвует дню недели");
 }