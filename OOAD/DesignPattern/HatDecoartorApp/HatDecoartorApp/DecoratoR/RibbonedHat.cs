using HatDecoartorApp.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoartorApp.DecoratoR
{
   public class RibbonedHat:IHAt

    {
        private IHAt _hat;
         private string _name;
        private double _price;
        public RibbonedHat(IHAt hat)
        {
            _hat = hat;
            _price = 100;
            _name = "Ribboned ";
        }
        public double GetCost()
        {
            return _price + _hat.GetCost();
        }

        public string GetDetails()
        {
            return _hat.GetDetails() + "\nRibbon: " + Convert.ToString(_price);
        }

        public string GetName()
        {
            return _name + _hat.GetName();
        }
    }
}
