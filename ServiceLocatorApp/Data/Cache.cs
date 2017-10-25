using System;
using System.Collections.Generic;
using ServiceLocatorApp.Services.Interfaces;

namespace ServiceLocatorApp.Data
{
    class Cache
    {
        private readonly List<IService> _services;

        public Cache()
        {
            _services = new List<IService>();
        }

        public IService GetService(string serviceName)
        {
            foreach (var service in _services)
            {
                if (service.GetName() != serviceName) continue;

                Console.WriteLine($"Returning cached {serviceName} object");
                return service;
            }
            return null;
        }

        public void AddService(IService newService)
        {
            var existingService = false;

            foreach (var service in _services)
            {
                if (service.GetName() == newService.GetName())
                {
                    existingService = true;
                }
            }

            if (!existingService)
            {
                _services.Add(newService);
            }
        }
    }
}