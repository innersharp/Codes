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
        public bool Find(int[] NumberStore, int SearchNum)
        {
            bool isFind = false;

            foreach (int num in NumberStore)
            {
                if(num== SearchNum)
                {
                    isFind = true;
                    break;
                }
            }
            return isFind;
        }

    }
}
