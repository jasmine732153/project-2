using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 7;
            int Sum;
            Sum = 0;
            while (i  <= 12)
            {
                Sum += i;
                i++;
                
            }
            Console.WriteLine(" Sum = {0}", Sum);
            Console.ReadLine();

        }
    }
}
