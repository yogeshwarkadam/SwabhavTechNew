using HatDecoartorApp.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoartorApp.DecoratoR
{
    class GoldenHat:IHAt
    {
        private IHAt _hat;
        private double _price;
        private string _name;
        public GoldenHat(IHAt hat)
        {
            _hat = hat;
            _price = 300;
            _name = "Golden ";
        }

        public double GetCost()
        {
            return _price + _hat.GetCost();
        }

        public string GetDetails()
        {
            return _hat.GetDetails() + "\nGolder Color: " + Convert.ToString(_price);
        }

        public string GetName()
        {
            return _name + _hat.GetName();
        }
    }
}
