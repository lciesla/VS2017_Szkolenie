using System;
using System.Threading.Tasks;
using NLog;
using Topshelf;

namespace Pocztowy.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(
                s =>
                {
                    s.SetServiceName("LukaszService");
                    s.SetDisplayName("TopShelf example");
                    s.StartAutomatically();
                    s.Service<MyService>(
                        service =>
                        {
                            service.ConstructUsing(p => new MyService());
                            service.WhenStarted(p => p.Start());
                            service.WhenStopped(p => p.Stop());
                        }
                        );

                }
                );
            Console.WriteLine("Hello World!");
        }
    }

    public class MyService
    {
        private static Logger log = LogManager.GetCurrentClassLogger();

        private volatile bool continueFlag = true;

        public void Start()
        {
            log.Info($"{nameof(Start)}");
            continueFlag = true;
            Task.Run(() => DoWork());
        }

        public void DoWork()
        {
            while (continueFlag)
            {
                log.Info("działam");
            }
            log.Info("exit from while");
        }

        public void Stop()
        {
            log.Info($"{nameof(Stop)}");
            continueFlag = false;
        }
    }

}
