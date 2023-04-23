// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

double[] array = new double[15];
void MinMaxArray(double[] arr)
{
  double MinNum= 0;
  double MaxNum= 0;
  
  for(int i = 0; i < arr.Length; i++)
 {
    arr[i] = new Random().Next(-500,2500);
    Console.Write(arr[i]+" ");
 }
   for (int i = 1; i < arr.Length; i++)
 {
    if (arr[i] < MinNum) MinNum = arr[i];
    if (arr[i] > MaxNum) MaxNum = arr[i];
     
 }
     Console.WriteLine($"\nМинимальное число массива {MinNum}\nМаксимальное число массива {MaxNum}");
     Console.WriteLine($"Разница между максимальным и минимальным числом равна {MaxNum - MinNum}");
}
MinMaxArray(array);