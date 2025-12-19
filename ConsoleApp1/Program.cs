using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;
            int y = 20;
            int sum = x + y;
            Console.WriteLine("Addition is " + sum);
            Console.WriteLine("Addition is :{0}", sum);
            Console.WriteLine("Addition of {0} and {1} is {2}",x,y,sum);
            Console.WriteLine(sum);
            Console.ReadLine();

        }
    }
}
