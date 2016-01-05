using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) 
    {
        string time = Console.ReadLine();
        String[] split = time.Split(':');
        String secMin = time[3].ToString() + time[4].ToString() + ':' + time[6].ToString() + time[7].ToString();

        int hh = Convert.ToInt32(split[0]);
        
        if(time[8].Equals('A') && time[9].Equals('M') && hh != 12)
        {
            Console.WriteLine('0' + hh.ToString() +  ':' + secMin);
        }
        else if((time[8].Equals('A') && time[9].Equals('M')) && hh == 12)
        {
            Console.WriteLine("00:" + secMin);
        }
        else if((time[8].Equals('P') && time[9].Equals('M')) && hh != 12)
        {
            hh = hh + 12;
            Console.WriteLine(hh.ToString() +  ':' + secMin);
        }
        else if((time[8].Equals('P') && time[9].Equals('M')) && hh == 12)
        {
            Console.WriteLine(hh.ToString() +  ':' + secMin);
        }
        
    }
}
