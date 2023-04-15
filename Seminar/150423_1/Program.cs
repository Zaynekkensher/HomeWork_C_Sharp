﻿// C# program to check whether a number
// is Palindrome or not.
 
using System;
class GFG
{
    /* Iterative function to reverse digits of num*/
    static int reverseDigits(int num)
    {
        int rev_num = 0;
        while (num > 0) {
            rev_num = rev_num * 10 + num % 10;
            num = num / 10;
        }
        return rev_num;
    }
     
    /* Function to check if n is Palindrome*/
    static int isPalindrome(int n)
    {
     
        // get the reverse of n
        int rev_n = reverseDigits(n);
     
        // Check if rev_n and n are same or not.
        if (rev_n == n)
            return 1;
        else
            return 0;
    }
     
    /*Driver program to test reverseDigits*/
    public static void  Main()
    {
        int n = 4562;
        Console.WriteLine("Is " + n + " a Palindrome number? -> " +
            (isPalindrome(n) == 1 ? "true" : "false"));
     
        n = 2002;
         
        Console.WriteLine("Is " + n + " a Palindrome number? -> " +
            (isPalindrome(n) == 1 ? "true" : "false"));
 
    }
 
}
 
// This code is contributed
// by Hritik Raj ( ihritik )