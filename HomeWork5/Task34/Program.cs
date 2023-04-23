// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[10];

void EvenNumbersArray(int[] arr)
{
int count = 0;

for(int i = 0; i < array.Length; i++)
{
  arr [i]=new Random().Next(100,1000);

  if(arr[i]%2 == 0)
    {
        count++;
    }
}
 Console.WriteLine(string.Join(",", array));
 Console.WriteLine(count);
}
EvenNumbersArray(array);