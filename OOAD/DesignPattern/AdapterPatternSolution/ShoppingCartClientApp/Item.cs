﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartClientApp
{
   public interface Item
    {
        string ItemName();

        double ItemPrice();
    }
}
