using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerSharp.Codes.Search
{
    /// <summary>
    /// Sequential Search or Linear Search
    /// </summary>
    public class SequentialSearch
    {
        public string[] Vocabulary { get; set; }
        public string SearchWord { get; set; }
        
        public SequentialSearch()
        {            
            Console.WriteLine("Enter the sentence: ");
            Vocabulary = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter the Search Word: ");
            SearchWord = Console.ReadLine();                
        }
        public bool Find()
        {
            bool isFind = false;

            foreach (string str in Vocabulary)
            {
                if(str==SearchWord)
                {
                    isFind = true;
                    break;
                }
            }
            return isFind;
        }

    }
}
