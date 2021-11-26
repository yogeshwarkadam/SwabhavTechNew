using CarInspectionDecoratorApp.Model;
using CarInspectionDecoratorApp.Model.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInspectionDecoratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new OilChange(new TyreRotation(new CarInspection()));
            Console.WriteLine(service.GetDetails());
            Console.WriteLine("Total Cost:", service.GetPrice());
            Console.ReadKey();
        }
    }
}

