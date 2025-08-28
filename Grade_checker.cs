using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Checker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Your Marks:");
            int Marks = int.Parse(Console.ReadLine());

            if (Marks >= 50)
                Console.WriteLine("Pass");
            else
                Console.WriteLine("Fail");
            Console.ReadLine();


        }
    }
}
