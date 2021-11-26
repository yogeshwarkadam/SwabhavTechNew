using FactoryMethodLib.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryMethodLib.Product;

namespace FactoryMethodClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IAutoFactory factory = new AudiFactory();
            IAuto auto = factory.Make();
            auto.Start();
            auto.Stop();
        }
    }
}
