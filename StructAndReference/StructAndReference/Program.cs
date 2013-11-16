using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAndReference
{
    class Program
    {
        static void Main(string[] args)
        {
            var rc = new RandomClass();
            rc.WorkWithValue();
            rc.Display();

            Console.Read();
        }
    }



    public class SimpleExample
    {
        int value;
        public SimpleExample(ref int variableOfWhichINeedAReference)
        {
            //Of course this won't work, but I'll keep it simple.
            value = variableOfWhichINeedAReference;
        }
        public void DisplayValue()
        {
            Console.WriteLine(value.ToString(CultureInfo.InvariantCulture));
        }
        public void UpdateValue(int newValue)
        {
            value = newValue;
        }
    }
    public class RandomClass
    {
        int myValue = 10;
        private SimpleExample s;

        public RandomClass()
        {
            s = new SimpleExample(ref myValue);
        }
        public void WorkWithValue()
        {
            myValue++;
            s.UpdateValue(myValue);
        }

        public void Display()
        {
            s.DisplayValue();
        }

    }



}
