using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoartorApp.Decorator
{
   
        public class PremiumHat : IHAt
        {
            private string _name;
            private double _price;
            public PremiumHat()
            {
                _name = "PREMIUM HAT";
                _price = 1000;
            }
            public double GetCost()
            {
                return _price;
            }

            public string GetDetails()
            {
                return "Premium Hat: " +"Rs:"+ Convert.ToString(_price);
            }

            public string GetName()
            {
                return _name;
            }
        }
}
