using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percentage_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
           //help
            string sToCheck;
            // Console.WriteLine("Enter line you want to check:");
            // sToCheck = Console.ReadLine();
            Console.WriteLine("UwU");
            while (true)
            {
                Console.WriteLine("Enter line you want to check:");
                sToCheck = Console.ReadLine();
                if (sToCheck!="")
                {
                    break;
                }
            }
                

            

            Console.WriteLine("Enter character you want to find in your line:");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();
            double otvet = CheckForChar(sToCheck, c);

            Console.WriteLine("Your answer is:{0:P1}.",otvet);
            

            Console.ReadLine();
            

        }

        static double CheckForChar(string x, char y)
        {
            var Pm = x.Length;
            var Pf = 0;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i].Equals(y))
                {
                    Pf++;
                    
                }
               
            }

          

            
                double Answ = (double)Pf / Pm;
            
             
            
            return Answ;
        }
    }
}
