using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Data
{
    public static class ServiceLocator
    {
        private static Dictionary<Type, Func<object>> services = new Dictionary<Type, Func<object>>();

        public static void Register<TService, TImplementation>() where TImplementation : new()
        {
            services[typeof(TService)] = () => new TImplementation();
        }

        public static TService GetService<TService>()
        {
            return (TService)services[typeof(TService)].Invoke();
        }

        public static void Register<TService>(Func<TService> factory)
        {
            services[typeof(TService)] = () => factory.Invoke();
        }
    }
}
