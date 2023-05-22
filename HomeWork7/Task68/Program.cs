Console.Clear();

long m = EnterNumbers("Enter m: ");
long  n = EnterNumbers("Enter n: ");

long  functionAkkerman = Ack(m, n);

Console.Write($"Function the Akkerman = {functionAkkerman} ");

long  Ack(long  m, long n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

long EnterNumbers(string input) 
{
  Console.Write(input);
  long  output = Convert.ToInt64(Console.ReadLine());
  return output;
}