using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) 
    {
        int N = Convert.ToInt32(Console.ReadLine());
        
        for(int i = 1; i <= N; i++)
        {
            for(int j = 1; j <= N; j++)
            {
                if((i+j) > N)
                    Console.Write("#");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
        
        
        
}
