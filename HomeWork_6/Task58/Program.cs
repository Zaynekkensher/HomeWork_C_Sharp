 Console.Clear();
 Console.WriteLine($"\nEnter size matrix and range of random numbers:");
 int a = EnterNumbers("Enter numbers the rows first matrix: ");
 int b = EnterNumbers("Enter numbers the columns first matrix(and rows second matrix): ");
 int c = EnterNumbers("Enter numbers the columns second matrix: ");
 int Line = EnterNumbers("Введите диапазон случайных чисел: от 1 до ");

 int[,] firstMartrix = new int[a, b];
 InitArray(firstMartrix);
 Console.WriteLine($"\nFirst matrix:");
 WriteArray(firstMartrix);

 int[,] secomdMartrix = new int[b, c];
 InitArray(secomdMartrix);
 Console.WriteLine($"\nSecond matrix:");
 WriteArray(secomdMartrix);

 int[,] resultMatrix = new int[a,c];

 MultMatrix(firstMartrix, secomdMartrix, resultMatrix);
 Console.WriteLine($"\nMultiplication first matrix on second matrix:");
 WriteArray(resultMatrix);

 void MultMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
 {
   for (int i = 0; i < resultMatrix.GetLength(0); i++)
   {
     for (int j = 0; j < resultMatrix.GetLength(1); j++)
     {
       int sum = 0;
       for (int k = 0; k < firstMartrix.GetLength(1); k++)
       {
         sum += firstMartrix[i,k] * secomdMartrix[k,j];
       }
       resultMatrix[i,j] = sum;
     }
   }
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
       array[i, j] = new Random().Next(Line);
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