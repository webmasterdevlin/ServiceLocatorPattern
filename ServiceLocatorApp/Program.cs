using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLocatorApp.Services.Interfaces;

namespace ServiceLocatorApp
{
    class Program // This is the Client
    {
        static void Main(string[] args)
        {
            IService service = ServiceLocator.GetService("BusService");
            service.Execute();
            Console.WriteLine();

            service = ServiceLocator.GetService("TaxiService");
            service.Execute();
            Console.WriteLine();

            service = ServiceLocator.GetService("BusService");
            service.Execute();
            Console.WriteLine();

            service = ServiceLocator.GetService("TaxiService");
            service.Execute();
            Console.WriteLine();

        }
    }
}
