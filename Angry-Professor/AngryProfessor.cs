using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        
          String numTests = Console.ReadLine();
          int onTime = 0;
          for(int i = 0; i < Convert.ToInt32(numTests); i++)
          {
              
              String firstLine = Console.ReadLine();
              String secondLine = Console.ReadLine();
              
              String[] firSplit = firstLine.Split(' ');
              String[] secSplit = secondLine.Split(' ');
              
              for(int j = 0; j < secSplit.Length; j++)
              {
                  if(Convert.ToInt32(secSplit[j]) <= 0)
                  {
                      onTime++;
                  }

              }
              
              if(onTime >= Convert.ToInt32(firSplit[1]))
                  Console.WriteLine("NO");
              else
                  Console.WriteLine("YES");
              onTime = 0;
          }
        
        
        }
    }

