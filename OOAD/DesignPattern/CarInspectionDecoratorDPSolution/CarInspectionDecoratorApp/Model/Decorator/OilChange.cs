using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInspectionDecoratorApp.Model.Decorator
{
    public class OilChange:ICarService
    {
        private double _price;
        private ICarService _service;
        public OilChange(ICarService service)
        {
            _service = service;
            _price = 200;
        }
        public double GetPrice()
        {
            return _price + _service.GetPrice();
        }

        public string GetDetails()
        {
            return _service.GetDetails() + "Oil Changing charges: " + Convert.ToString(_price);
        }
    }
}
