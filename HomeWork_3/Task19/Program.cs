// Напишите программу, которая принимает на вход пятизначное число и проверяет, является 
//ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// static int reverseDigits(int num)
//     {
//         int rev_num = 0;
//         while (num > 0) {
//             rev_num = rev_num * 10 + num % 10;
//             num = num / 10;
//         }
//         return rev_num;
//     }
     
//     /* Function to check if n is Palindrome*/
//     static int isPalindrome(int n)
//     {
     
//         // get the reverse of n
//         int rev_n = reverseDigits(n);
     
//         // Check if rev_n and n are same or not.
//         if (rev_n == n)
//             return 1;
//         else
//             return 0;
//     }

//     int EnterData(string text)
// {
//     Console.WriteLine(text);
//     return (int.Parse(Console.ReadLine()));
// }
     
//     {
//         int n = EnterData("Введите значение x1: ");
//         Console.WriteLine("Is " + n + " a Palindrome number? -> " +
//         (isPalindrome(n) == 1 ? "true" : "false"));
//     }



int num,r,sum=0,t;
Console.Write("Введите пятизначное число: ");
num = int.Parse(Console.ReadLine());
if (num>9999 && num<100000)
{
for(t=num;num!=0;num=num/10)
{
r = num % 10;
sum = sum*10+r;
}
if(t == sum)
Console.Write($"{t} является палиндромом.");
else
Console.Write($"{t} не является палиндромом.");
} else
Console.Write("Введите пятизначное число!");