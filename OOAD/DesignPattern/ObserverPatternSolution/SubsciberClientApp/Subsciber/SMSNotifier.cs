using PublisherLib.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubsciberClientApp.Subsciber
{
    class SMSNotifier : INotifier
    {
        public void Notify(Account acc)
        {
            Console.WriteLine("SMS sent to: {0} {1} {2}  {3} {4}", acc.accno, acc.name, acc.balance, acc.mobileno, acc.email);
        }
    }
}
