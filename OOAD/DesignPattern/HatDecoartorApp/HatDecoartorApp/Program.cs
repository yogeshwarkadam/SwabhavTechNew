using HatDecoartorApp.Decorator;
using HatDecoartorApp.DecoratoR;
using HatDecoartorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoartorApp
{
     class Program
    {
        static void Main(string[] args)
        {
            var hat= new RibbonedHat(new GoldenHat(new PremiumHat()));
            PrintHatDetails(hat);
            var hat2 = new GoldenHat(new StandardHat());
            PrintHatDetails(hat2);
            Console.ReadKey();
        }

    

       public static void PrintHatDetails(IHAt hat)

        {
            Console.WriteLine("Hat Details:");
            Console.WriteLine("\n Name : ", hat.GetName());
            Console.WriteLine("\n Description:");
            Console.WriteLine(hat.GetDetails());
            Console.WriteLine("\n TotalCost: ", hat.GetCost());
        }
    }
}

