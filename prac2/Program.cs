using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prac2
{
    class Program
    {
        void square()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            square();
            
        }
    }
    
}

