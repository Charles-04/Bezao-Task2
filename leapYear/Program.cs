// See https://aka.ms/new-console-template for more information
using System;

public class LeapYear
{
   public static void Main()
   {
    int lastLeapYear = 2020;
    for (int i = 0; i < 20; i++)
    {
        lastLeapYear += 4;
        Console.Write("The next ");
        Console.Write(i +1);
        Console.Write(" Leap year(s) is ");
        Console.WriteLine(lastLeapYear);
        
    }
   }
   }