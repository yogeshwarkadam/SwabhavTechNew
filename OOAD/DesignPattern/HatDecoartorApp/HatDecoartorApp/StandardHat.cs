using HatDecoartorApp.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoartorApp.Model
{
    public class StandardHat:IHAt
    {
        private string _name;
        private double _price;

        public StandardHat()
        {
            _name = "Standard Hat";
            _price = 100;
        }
        public double GetCost()
        {
            return _price;
        }

        public string GetDetails()
        {
            return "Standard Hat: "+"Rs:" + Convert.ToString(_price);
        }

        public string GetName()
        {
            return _name;
        }
    }
}
