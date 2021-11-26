using PublisherLib.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SubsciberClientApp.Subsciber;

namespace SubsciberClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a1 = new Account(101 ," yogesh ",5000 ,  9657082193 ," yog@gmail.com");
            a1.AddNotifier(new SMSNotifier());
            a1.AddNotifier(new EmailNotifier());
            a1.Deposite(2000);
            
        }
    }
}
