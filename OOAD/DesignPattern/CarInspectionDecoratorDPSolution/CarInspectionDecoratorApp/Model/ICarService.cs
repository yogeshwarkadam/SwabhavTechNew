using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInspectionDecoratorApp.Model
{
    public interface ICarService
    {
        double GetPrice();
        string GetDetails();
    }
}
