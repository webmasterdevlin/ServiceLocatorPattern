using System;
using ServiceLocatorApp.Services.Interfaces;

namespace ServiceLocatorApp.Services.Implementations
{
    class TaxiService : IService
    {
        public void Execute()
        {
            Console.WriteLine("Executing TaxiService");
        }

        public string GetName()
        {
            return "TaxiService";
        }
    }
}