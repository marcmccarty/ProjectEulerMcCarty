/*Project Euler - Problem 19
 * You are given the following information, but you may prefer to do some research for yourself.
 * 
 * 1 Jan 1900 was a Monday.
 * Thirty days has September,
 * April, June and November.
 * All the rest have thirty-one,
 * Saving February alone,
 * Which has twenty-eight, rain or shine.
 * And on leap years, twenty-nine.
 * A leap year occurs on any year evenly divisible by 4, but not on a century unless it is divisible by 400.
 * How many Sundays fell on the first of the month during the twentieth century (1 Jan 1901 to 31 Dec 2000)?
 */
 
 using System;
 
 namespace ProjectEulerWorkspace
 {
     internal class Program
     {
         public static void Main(string[] args)
         {
             int totalDays = 0;
             int sundayFirst = 0;
             int year = 1901;
             bool leap = false;

             while (year < 2001)
             {
                 if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                 {
                     leap = true;
                 }

                 // January check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }
                 
                 totalDays += 31;

                 // February check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 // Leap adjustment
                 if (leap)
                 {
                     totalDays += 29;
                 }
                 else
                 {
                     totalDays += 28;
                 }

                 // March check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 31;
                 
                 // April check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 30;
                 
                 // May check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 31;
                 
                 // June check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 30;
                 
                 // July check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 31;
                 
                 // August check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 31;
                 
                 // September check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 30;
                 
                 // October check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 31;
                 
                 // November check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 30;
                 
                 // December check
                 if (totalDays % 7 == 0)
                 {
                     sundayFirst++;
                 }

                 totalDays += 31;
                 
                 leap = false;
                 year++;
             }
             
             Console.WriteLine(sundayFirst);
         }
     }
 }
