using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInspectionDecoratorApp.Model.Decorator
{
    public class TyreRotation:ICarService
    {
        private double _price;
        private ICarService _service;
        public TyreRotation(ICarService service)
        {
            _service = service;
            _price = 100;
        }
        public double GetPrice()
        {
            return _price + _service.GetPrice();
        }

        public string GetDetails()
        {
            return _service.GetDetails() + "Tyre Rotation Charges: " + Convert.ToString(_price);
        }
    }
}
