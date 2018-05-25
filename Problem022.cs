/*Project Euler - Problem 22
 * Using names.txt (right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.
 * Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
 *
 * For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.
 * So, COLIN would obtain a score of 938 × 53 = 49714.
 *
 * What is the total of all the name scores in the file?
 */
 
using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectEulerWorkspace
 {
     internal class Program
     {
         public static void Main(string[] args)
         {
             string line;
             
             StreamReader file = new StreamReader(@"C:\Users\owemcma1\Documents\names.txt");
             line = file.ReadLine();

             string[] names = line.Split(',');
             
             List<string> alphabetizedNames = new List<string>();

             for (int i = 0; i < names.Length; i++)
             {
                 names[i] = names[i].Trim('"');
                 alphabetizedNames.Add(names[i]);
             }
             
             alphabetizedNames.Sort();

             int nameScore = 0;
             int totalScore = 0;

             for (int i = 0; i < alphabetizedNames.Count; i++)
             {
                 for (int j = 0; j < alphabetizedNames[i].Length; j++)
                 {
                     nameScore += Convert.ToInt32(alphabetizedNames[i][j]) - 64;
                 }

                 nameScore = nameScore * (i + 1);
                 totalScore += nameScore;
                 nameScore = 0;
             }
             
             Console.WriteLine(totalScore);
         }
     }
 }
