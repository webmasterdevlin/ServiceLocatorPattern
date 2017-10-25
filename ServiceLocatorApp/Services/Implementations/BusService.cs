using System;
using ServiceLocatorApp.Services.Interfaces;

namespace ServiceLocatorApp.Services.Implementations
{
    class BusService : IService
    {
        public void Execute()
        {
            Console.WriteLine("Executing BusService");
        }

        public string GetName()
        {
            return "BusService";
        }
    }
}