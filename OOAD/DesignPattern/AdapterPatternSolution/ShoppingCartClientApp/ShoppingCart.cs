using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp
{
   public class ShoppingCart
    {
        public List<Item> items = new List<Item>();
        public double _totalPrice;
        public void Add(Item item)
        {
            items.Add(item);
        }

        public void Remove(Item item)
        {
            items.Remove(item);
        }
        public double TotalPrice()
        {
            foreach ( Item i in items)
            {
                _totalPrice += i.ItemPrice();
            }
            return _totalPrice;
        }
    }
}
