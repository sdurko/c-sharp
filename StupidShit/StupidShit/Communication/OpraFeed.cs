using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StupidShit.Interfaces;

namespace StupidShit
{
    class OpraFeed : IMarketDataClient
    {
        public void Subscribe(string name)
        {
            Console.WriteLine(string.Format("Now connected to {0}", name));
        }

        public void Unsubscribe(string name)
        {
            Console.WriteLine(string.Format("{0} has been disconnected.", name));
        }

        public void Connect()
        {
            Console.WriteLine("Connected to Opra");
        }

        public void Disconnect()
        {
            Console.WriteLine("Disconnected from Opra");
        }
    }
}
