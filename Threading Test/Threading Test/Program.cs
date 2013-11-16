using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Collections.Concurrent;

namespace Threading_Test
{


    class Program
    {
        static void Main()
        {

 //           Parallel.Invoke(
 //() => new WebClient().DownloadFile("http://www.linqpad.net", "lp.html"),
 //() => new WebClient().DownloadFile("http://www.jaoo.dk", "jaoo.html"));

 //           Console.ReadLine();
          
            Task.Run(() =>
            {
                Stopwatch ws = new Stopwatch();

                ws.Start();

                for (int x = 0; x < 1000; x++)
                {
                    int w = 5;
                }

                ws.Stop();

                Console.WriteLine("For Loop on Task: {0}", ws.Elapsed);
            });

            var test = new Thread(new ThreadStart(() =>
                                                      {
                                                          Stopwatch ws = new Stopwatch();

                                                          ws.Start();

                                                          for (int x = 0; x < 1000; x++)
                                                          {
                                                              int w = 5;
                                                          }

                                                          ws.Stop();

                                                          Console.WriteLine("For Loop on Background Thread: {0}", ws.Elapsed);

                                                      }));

            test.SetApartmentState(ApartmentState.STA);
            test.Start();

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int x = 0; x < 1000; x++)
            {
                int w = 5;
            }

            sw.Stop();

            Console.WriteLine("For Loop on Main Thread:         {0}", sw.Elapsed);


            sw.Reset();

            sw.Start();

            Parallel.For(0, 1000, i =>
            {
                int x = 5;
            });

            sw.Stop();

            Console.WriteLine("Parallel For on Main Thread: {0}", sw.Elapsed);

            Console.ReadLine();

        }
    }
}
