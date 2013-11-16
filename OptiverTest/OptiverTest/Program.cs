using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptiverTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var uniqueNumbers = new HashSet<int>();

            var ar1 = new int[5];
            var ar2 = new int[5];


            for (int x = 0; x < 3;x++)
            {
                ar1[x] = x;
                ar2[x] = x + 1;
            }

            uniqueNumbers.UnionWith(ar1);
            uniqueNumbers.UnionWith(ar2);


        }
    }
}
