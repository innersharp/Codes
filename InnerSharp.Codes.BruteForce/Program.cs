using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerSharp.Codes.Search
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.WriteLine("Enter line: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter Pattern to find in the above Line: ");
            string pattern = Console.ReadLine();

            BruteForceSearch objBFS = new BruteForceSearch {
                                    Text = str.ToCharArray(),
                                    Pattern = pattern.ToCharArray() };

            int indexOf = objBFS.IndexOf();

            if(indexOf>-1)
            {
                Console.WriteLine(indexOf);
            }
            else
            {
                Console.WriteLine("Pattern Not Found");
            }
            Console.ReadLine();*/
            SequentialSearch objSS = new SequentialSearch();
            Console.WriteLine(objSS.Find().ToString());
        }
        
    }
}
