using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerSharp.Codes.BruteForce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter line: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter Pattern to find in the above Line: ");
            string pattern = Console.ReadLine();

            BruteForce objBF = new BruteForce {
                                    Text = str.ToCharArray(),
                                    Pattern = pattern.ToCharArray() };

            int indexOf = objBF.IndexOf();

            if(indexOf>-1)
            {
                Console.WriteLine(indexOf);
            }
            else
            {
                Console.WriteLine("Pattern Not Found");
            }
            Console.ReadLine();
        }
        
    }
}
