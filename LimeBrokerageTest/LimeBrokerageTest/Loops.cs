using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimeBrokerageTest
{
    class Loops
    {

        public static void RunLoops()
        {
            int[] integers = new int[]{10,20,30,40};
            

            //starting at zero, the loop will run exactly the length of the array
            for(int x = 0;x<integers.Length;x++)
            {
                Console.WriteLine(integers[x].ToString());
            }


        }

    }
}
