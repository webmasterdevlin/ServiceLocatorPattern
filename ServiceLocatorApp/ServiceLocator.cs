using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ServiceLocatorApp.Data;
using ServiceLocatorApp.Services.Interfaces;

namespace ServiceLocatorApp
{
    sealed class ServiceLocator
    {
        public static ServiceLocator Instance { get; set; }

        public static Cache Cache = new Cache();

        public static IService GetService(string serviceName)
        {
            // First check the service object available in cache
            IService service = Cache.GetService(serviceName);

            if (service != null)
            {
                return service;
            }

            /*
             * If service object is not available in cache, do the lookup using
             * service name initial context and get the service object and add it to
             * the cache for future use.
             */
            InitialContext context = new InitialContext();
            IService serviceObj = (IService) context.LookUp(serviceName);
            Cache.AddService(serviceObj);
            return serviceObj;
        }
    }
}
