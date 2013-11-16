using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using StupidShit.Interfaces;

namespace StupidShit
{
    class Session : IDisposable
    {
        private IMarketDataClient _marketDataClient = null;
        private IStorageClient _storageClient = null;

        private bool _run = true;

        public void StopListening() { _run = false; }

        Session(IMarketDataClient marketDataClient, IStorageClient storageClient)
        {
            _marketDataClient = marketDataClient;
            _storageClient = storageClient;
        }

        public Session()
        {
        }

        public void Run() 
        {
            Task.Factory.StartNew(() => 
            {
                while (_run)
                {
                    Parallel.For(0, 1000000, x => { Car car = new Car(); });
                }
            });

        }

        private void Listen()
        {
        }

        public void Dispose()
        {
            _storageClient = null;
            _marketDataClient = null;

            this.StopListening();
        }
    }
}
