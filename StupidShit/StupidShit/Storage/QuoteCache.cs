using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StupidShit.Interfaces;

namespace StupidShit
{
    class QuoteCache : IStorageClient
    {
        private readonly Dictionary<string, Stock> _stocks = new Dictionary<string, Stock>();

        private static readonly object _locker = new object();

        public Stock GetStock(string name)
        {
            Stock result = null;


            //Func<Dictionary<string, Stock>> function1 =  () => _stocks;

            //Func<Dictionary<string, Stock>, bool> function2 = x => x.Count > 5;

            //var test = _stocks.FirstOrDefault(s => s.Key == "");

            lock (_locker)
            {
                if (!_stocks.TryGetValue(name.ToUpper(), out result))
                {
                    result = new Stock() { Name = name, Last = new Random(25).NextDouble() };
                }
            }



            return result;
        }

        public bool Save(string name)
        {
            throw new NotImplementedException();
        }

        public void Delete(string name)
        {
            throw new NotImplementedException();
        }

        public void Connect()
        {
            throw new NotImplementedException();
        }

        public void Disconnect()
        {
            throw new NotImplementedException();
        }
    }
}
