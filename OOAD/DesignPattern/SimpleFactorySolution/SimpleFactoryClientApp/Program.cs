using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleFactoryLib.Factory;


namespace SimpleFactoryClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
           // Part1();
            Part2();
            Console.ReadLine();
        }

        private static void Part1()
        {
            var f1 = new AutoMobileFactory();
            var Auto = f1.Make(AutoType.Audi);
            Auto.Start();
            Auto.Stop();
        }

        private static void Part2()
        {
            var factory1 = AutoMobileFactory.GetInstance();
            var auto1 = factory1.Make(AutoType.Tesla);
            auto1.Start();
            auto1.Stop();
            Console.WriteLine(factory1.GetHashCode());

            var factory2 = AutoMobileFactory.GetInstance();
            var auto2 = factory2.Make(AutoType.Audi);
            auto2.Start();
            auto2.Stop();
            Console.WriteLine(factory2.GetHashCode());
        }
    }

   
}
