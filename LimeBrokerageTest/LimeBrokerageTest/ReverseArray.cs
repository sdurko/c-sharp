using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimeBrokerageTest
{
    static class ReverseArray
    {
        private static int[] seqList = new int[] {1,2,3,4,5,6,7,8,9,10};

        public static void Reverse()
        {
            PrintArray("Before: ");

            //We only need to iterate through half of the array to reverse the elements, otherwise we would set them all back to their original state
            //You can change the values in the array if you are accessing it through the index, you cannot due this for something like a foreach statement
            for (int x = 0; x < seqList.Length/2; x++)
            {
                //First copy the value at the front of the list so we can assign to the tail part of the list later.
                var temp = seqList[x];

                //We have to find the end of the list and keep counting backwards.
                //To do this we start with the length of the list, in ths case 10, and subtract the enumerating index minus one to compensate for the offset
                //example:  length = 10;  x = 0    so, 10-(0+1) = 9
                //Since all collections start with zero base, 9 is the last position in an array of 10  [0,1,2,3,4,5,6,7,8,9]
                var tailIndex = seqList.Length - (x + 1);

                //This is the first part of the swap, set the head values (first indexes) to the tail values (last indexes)
                //result:
                // [1,2,3,4,5,6,7,8,9,10]   
                //has been changed to:
                // [10,2,3,4,5,6,7,8,9,10]
                seqList[x] = seqList[tailIndex]; 

                //Now we set the tail values to the copied value at the beginning
                // [10,2,3,4,5,6,7,8,9,10]
                //has been changed to:
                // [10,2,3,4,5,6,7,8,9,1]
                seqList[tailIndex] = temp;

            }

            PrintArray("After:  ");

        }

        public static void PrintArray(string arrayType)
        {
            Console.Write(arrayType);

            foreach (var i in seqList)
            {
                Console.Write(i.ToString() + ", ");
            }

            Console.WriteLine("");
        }
    }
}
