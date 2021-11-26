using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInspectionDecoratorApp.Model
{
    class CarInspection:ICarService
    {
        private double _price;
        public CarInspection()
        {
            _price = 1000;
        }
        public double GetPrice()
        {
            return _price;
        }

        public string GetDetails()
        {
            return " Car Inspection: " + Convert.ToString(_price);
        }
    }
}
