//Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.

 Console.Clear();
 Console.WriteLine($"\nInput the size Array...:");
 int m = EnterNumbers("Enter m: ");
 int n = EnterNumbers("Enter n: ");
 int Line = EnterNumbers("Enter Range 1 to... ");

 int[,] array = new int[m, n];
 InitArray(array);
 WriteArray(array);

 int minSumRows = 0;
 int sumRows = SumRowsElements(array, 0);
 for (int i = 1; i < array.GetLength(0); i++)
 {
   int tempSumRows = SumRowsElements(array, i);
   if (sumRows > tempSumRows)
   {
     sumRows = tempSumRows;
     minSumRows= i;
   }
 }

 Console.WriteLine($"\n{minSumRows+1} - sttring min summ ({sumRows}) elements ");


 int SumRowsElements(int[,] array, int i)
 {
   int sumRows = array[i,0];
   for (int j = 1; j < array.GetLength(1); j++)
 {
     sumRows += array[i,j];
 }
   return sumRows;
 }

 int EnterNumbers(string enter)
 {
   Console.Write(enter);
   int output = Convert.ToInt32(Console.ReadLine());
   return output;
 }

 void InitArray(int[,] array)
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
     for (int j = 0; j < array.GetLength(1); j++)
     {
       array[i, j] = new Random().Next(i);
     }
   }
 }

 void WriteArray (int[,] array)
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
     for (int j = 0; j < array.GetLength(1); j++)
     {
       Console.Write(array[i,j] + " ");
     }
     Console.WriteLine();
   }
 }
