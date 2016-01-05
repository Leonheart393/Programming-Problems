using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int N = Convert.ToInt32(Console.ReadLine());
        String numin = Console.ReadLine();
        float total = 0;
        float pos = 0;
        float neg = 0;
        float zer = 0;
        String[] numsplit = numin.Split(' ');
        int[] numarr = new int[numsplit.Length];
        
        for(int i = 0; i < N; i++)
        {
            numarr[i] = Convert.ToInt32(numsplit[i]);
        }
        
        for(int i = 0; i < numarr.Length; i++)
        {
            total++;
            if(numarr[i] > 0)
                pos++;
            if(numarr[i] == 0)
                zer++;
            if(numarr[i] < 0)
                neg++;
        }
        
        Console.WriteLine(pos/total);
        Console.WriteLine(neg/total);
        Console.WriteLine(zer/total);
   
    }
}
