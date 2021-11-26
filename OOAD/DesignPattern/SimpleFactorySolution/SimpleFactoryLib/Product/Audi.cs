using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Product
{
    internal class Audi : IAuto
    {
        public void Start()
        {
            Console.WriteLine("Audi is starting");
        }

        public void Stop()
        {
            Console.WriteLine("Audi is stoping");
        }
    }
}
