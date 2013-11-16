using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StupidShit;

namespace UnitTestProject1
{
    [TestClass]
    public class SessionTest
    {
        [TestInitialize]
        public void Test()
        {
            Console.WriteLine("intialize");



            var one = new Session();
            one.Run();
        }

        //[TestMethod]
        //public void TestMethod1()
        //{
        //    Console.WriteLine("Method");
        //}
    }
}
