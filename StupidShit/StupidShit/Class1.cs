using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidShit
{
    #region Method Hiding Tests
    public class BaseClass : IDisposable
    {
        public string Steve(int x)
        { return "Base-Steve"; }

        public string Jack()
        { return "Jacky"; }

        public void Dispose()
        {
            Console.WriteLine("BaseClass disposing");
        }

        public void Notify(string info)
        {
        }
    }

    public class DerivedClass : BaseClass
    {

        public string Steve(int x)
        { return "Derived - Steve"; }
    }
    public class DerivedClass2 : DerivedClass
    {

        public string Mike(int x)
        { return "Derived2 - Steve"; }
    }

    public class Mouse
    {
        public Mouse()
        {
            var d1 = new DerivedClass2();
            
            d1.Steve(5);
        }
    }
    #endregion


    public static class Phone
    {
        public static readonly string Name = "Steve";

        public static void Test() 
        { Console.WriteLine(Name); }

        static Phone() 
        { Name = "Chewie"; }
    }

    public class Car
    {
        public static int a = 1;
        public int b = 2;

        private Phone _phone;

        public Car()
        {
            a = 10;
            b = 20;
        }

        static Car()
        {
            a = 30;
        }

        public void Print()
        {
            Console.WriteLine(a.ToString());
            Console.WriteLine(b.ToString());

        }
    }

    public class Driver
    {
        public static readonly Driver _instance = new Driver();


        private Driver()
        {
            int x = 5;
        }

        public void DoNothing()
        {}


        //public static Driver Instance
        //{ get { return this; } }

        //public Driver()
        //{
        //    var c1 = new DerivedClass();

        //}
    }

    public static class Settings
    {
        public static void Test()
        {
            BaseClass test = new BaseClass();
        }
    }
}