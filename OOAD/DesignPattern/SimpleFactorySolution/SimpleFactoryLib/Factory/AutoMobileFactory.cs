using SimpleFactoryLib.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryLib.Factory
{
    public class AutoMobileFactory
    {
        private static AutoMobileFactory _autofactory;
        private static object locker = new object();
        public AutoMobileFactory()
        {
            Console.WriteLine("instance created");
        }
        public IAuto Make(AutoType autotype)
        {
            if (autotype == AutoType.BMW)
            {
                return new BMW();
            }
            else if (autotype == AutoType.Tesla)
            {
                return new Tesla();
            }
            else
            {
                return new Audi();
            }
        }

        public static AutoMobileFactory GetInstance()
        {
            lock (locker)
            {
                if (_autofactory == null)
                {
                    _autofactory = new AutoMobileFactory();
                }
            }
            return _autofactory;
        }
    }
}
