/*Project Euler - Problem 18
  * By starting at the top of the triangle below and moving to adjacent numbers on the row below, the maximum total from top to bottom is 23.
  *
  *    3
  *   7 4
  *  2 4 6
  * 8 5 9 3
  * 
  * That is, 3 + 7 + 4 + 9 = 23.
  * 
  * Find the maximum total from top to bottom of the triangle below:
  * [Omitted triangle]
  * NOTE: As there are only 16384 routes, it is possible to solve this problem by trying every route. 
  * However, Problem 67, is the same challenge with a triangle containing one-hundred rows; 
  * it cannot be solved by brute force, and requires a clever method! ;o)
  */
 
 using System;
 using System.IO;
 
 namespace ProjectEulerWorkspace
 {
     internal class Program
     {
         public static void Main(string[] args)
         {
             int[,] triangle = new int[15,15];
 
             string triangleStr = "";
             string line;
             
             StreamReader file = new StreamReader(@"C:\Users\owemcma1\Documents\test18.txt");
             while ((line = file.ReadLine()) != null)
             {
                 triangleStr += line;
             }
             
             file.Close();
 
             string[] splitNums = triangleStr.Split(' ');
             
             for (int k = 0; k < splitNums.Length; k++)
             {
                 if (splitNums[k].StartsWith("0"))
                 {
                     splitNums[k] = splitNums[k].Remove(0,1);
                 }
             }
 
             
             int triLevelCount = 0;
             int triCurrentCount = 0;
             int overallCount = 0;
 
             while (overallCount < splitNums.Length)
             {
                 while (triCurrentCount <= triLevelCount)
                 {
                     triangle[triLevelCount, triCurrentCount] = Convert.ToInt32(splitNums[overallCount]);
                     
                     overallCount++;
                     triCurrentCount++;
                 }
                 
                 triLevelCount++;
                 triCurrentCount = 0;
             }
 
             int[] replacements = new int[15];
 
             for (int z = 0; z < replacements.Length; z++)
             {
                 replacements[z] = 0;
             }
 
             // Start from bottom of triangle
             for (int row = 14; row >= 0; row--)
             {
                 for (int item = 0; item < row; item++)
                 {
                     if (triangle[row, item] > triangle[row, item + 1] && triangle[row, item] > replacements[item])
                     {
                         replacements[item] = triangle[row, item] + triangle[row - 1, item];
                     }
                     else if (triangle[row, item] < triangle[row, item + 1] && triangle[row, item + 1] > replacements[item])
                     {
                         replacements[item] = triangle[row, item + 1] + triangle[row - 1, item];
                     }
                 }
 
                 for (int r = 0; r < row; r++)
                 {
                     if (replacements[r] != 0)
                     {
                         triangle[row - 1, r] = replacements[r];
                         replacements[r] = 0;
                     }
                 }
             }
         }
     }
 }
