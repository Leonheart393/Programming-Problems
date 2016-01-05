using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int N = Convert.ToInt32(Console.ReadLine());
        
        String temp ="";
        
        for(int i = 0; i < N; i++)
        {
            temp += Console.ReadLine() + " ";
        }
        
        String[] Ssplit = temp.Trim().Split(' ');
        
        int[,] arr = new int[N,N];
        
        for(int i = 0; i < N; i++)
        {
            for(int j = 0; j < N; j++)
            {              
                arr[i,j] = int.Parse(Ssplit[(i*N)+j]);                          
            }
        }
        
        int sumD1 = 0;
        int sumD2 = 0;
        for(int i = 0; i < N; i++)
        {
            sumD1 += arr[i,i]; 
                         
            sumD2 += arr[i, N-1-i];
        }
        Console.WriteLine(Math.Abs(sumD1-sumD2).ToString());
    }
}
