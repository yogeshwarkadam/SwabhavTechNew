using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublisherLib.Publisher
{
   public class Account
    {
        private int _accno;
        private string _name;
        private double _balance;
        private double _mobileno;
        private string _email;
        private List<INotifier> notifier1 = new List<INotifier>();

        public Account(int accno,string name,double balance)
        {
            this._accno = accno;
            this._name = name;
            this._balance = balance;

        }
        public Account(int accno, string name, double balance,double mobileno,string email)
        {
            this._accno = accno;
            this._name = name;
            this._balance = balance;
            this._mobileno = mobileno;
            this._email = email;
        }

        public int accno
        {
            get
            {
                return _accno;
            }
        }
        public string name
        {
            get
            {
                return _name;
            }
        }
        public double balance
        {
            get
            {
                return _balance;
            }
        }
        public double mobileno
        {
            get
            {
                return _mobileno;
            }
        }
        public string email
        {
            get
            {
                return _email;
            }
        }
        

        public void Deposite(Double amount)
        {
           
            _balance += amount;
            Notify();
        }

        public void Withdraw(Double amount)
        {
          
            _balance -= amount;
            Notify();
        }
        public void AddNotifier(INotifier notifier)
        {
            notifier1.Add(notifier);
        }
        private void Notify()
        {
            foreach (INotifier notifier in notifier1 )
            {
                notifier.Notify(this);
            }
        }
    }
}
