using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Services.Account;
using PublisherLib.Publisher;
using Account = PublisherLib.Publisher.Account;

namespace SubsciberClientApp.Subsciber
{
    class EmailNotifier : INotifier
    {
        public void Notify(Account acc)
        {
            Console.WriteLine("email sent to: {0} {1} {2}  {3} {4}",acc.accno,acc.name,acc.balance,acc.mobileno,acc.email);
        }

      
    }
}
