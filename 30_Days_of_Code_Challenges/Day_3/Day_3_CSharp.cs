using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    static void Main(String[] args) {
        int N = Convert.ToInt32(Console.ReadLine());
     
        if (N % 2 == 1)
            {
            Console.WriteLine("Weird");
        }
        else if (N % 2 == 0)
            {
            if (N <= 20 && N >= 6)
                {
                Console.WriteLine("Weird");
            }
            else {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
