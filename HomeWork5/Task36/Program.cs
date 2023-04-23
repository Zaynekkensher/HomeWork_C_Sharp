// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = new int[10];

void NotEvenPosArray (int[] arr)
{
    int SummPozIndArray = 0;
    for(int i = 0; i < array.Length; i++)
  {
     arr [i]=new Random().Next(15);
      if(i % 2 == 0)
      {
        SummPozIndArray+=arr[i];
      }    
  }

 Console.WriteLine(string.Join(",", array));
 Console.WriteLine(SummPozIndArray);
}
NotEvenPosArray(array);