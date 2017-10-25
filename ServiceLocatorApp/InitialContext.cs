using System;
using ServiceLocatorApp.Services.Implementations;

namespace ServiceLocatorApp
{
    class InitialContext
    {
        public object LookUp(string serviceName)
        {
            switch (serviceName)
            {
                case "BusService":
                    Console.WriteLine("Looking up and creating a new BusService object");
                    return new BusService();

                case "TaxiService":
                    Console.WriteLine("Looking up and creating a new TaxiService object");
                    return new TaxiService();
            }

            return null;
        }
    }
}