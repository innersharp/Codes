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

            #region BruteForceSearch
            /*
            Console.WriteLine("Enter line: ");
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
            Console.ReadLine();
            */
            #endregion
            #region LinearSearch
                int[] NumberStore = { 10, 20, 30, 40, 50 };
                int SearchNum = 50;

                SequentialSearch objSS = new SequentialSearch();
                if (objSS.Find(NumberStore, SearchNum))
                    Console.WriteLine("Search Number found in Number Store");
                else
                    Console.WriteLine("Search Number not found in Number Store");
            #endregion
        }

    }
}
