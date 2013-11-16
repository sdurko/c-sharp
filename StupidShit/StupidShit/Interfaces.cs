using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StupidShit.Interfaces
{
    interface IClient
    {
        void Connect();
        void Disconnect();
    }

    interface IMarketDataClient : IClient
    {
        void Subscribe(string name);
        void Unsubscribe(string name);
    }

    interface IStorageClient : IClient
    {
        Stock GetStock(string name);
        bool Save(string name);
        void Delete(String name);
    }

}