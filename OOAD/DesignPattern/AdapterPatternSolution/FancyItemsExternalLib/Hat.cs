using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FancyItemsExternalLib
{
   public class Hat
    {
        private string _shortname;
        private string _longname;
        private double _baseprice;
        private double _GST = 8;

        public Hat(string shortname,string longname,double baseprice)
        {
            this._shortname = shortname;
            this._longname = longname;
            this._baseprice = baseprice;
        }
        public double GetPrice()
        {
            double tax = _baseprice * _GST / 100;
            return _baseprice + tax;
        }
        public string GetShortName()
        {
            return _shortname;
        }
        public string GetLongName()
        {
            return _longname;
        }
    }
}
