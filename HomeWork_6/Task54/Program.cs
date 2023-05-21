 Console.Clear();
 Console.WriteLine($"\nInput the size Array...:");
 int m = EnterNumbers("Enter m: ");
 int n = EnterNumbers("Enter n: ");
 int Line = EnterNumbers("Enter Range 1 to... ");

 int[,] array = new int[m, n];
 InitArray(array);
 WriteArray(array);

 Console.WriteLine($"\nSorted array...: ");
 LocArrLines(array);
 WriteArray(array);
 
 void LocArrLines(int[,] array)
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
     for (int j = 0; j < array.GetLength(1); j++)
     {
       for (int k = 0; k < array.GetLength(1) - 1; k++)
       {
         if (array[i, k] < array[i, k + 1])
         {
           int temp = array[i, k + 1];
           array[i, k + 1] = array[i, k];
           array[i, k] = temp;
         }
       }
     }
   }
 }

 int EnterNumbers(string input)
 {
   Console.Write(input);
   int output = Convert.ToInt32(Console.ReadLine());
   return output;
 }

 void InitArray(int[,] array)
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
     for (int j = 0; j < array.GetLength(1); j++)
     {
       array[i, j] = new Random().Next(Line);
     }
   }
 }

 void WriteArray(int[,] array)
 {
   for (int i = 0; i < array.GetLength(0); i++)
   {
     for (int j = 0; j < array.GetLength(1); j++)
     {
       Console.Write(array[i, j] + " ");
     }
     Console.WriteLine();
   }
 }