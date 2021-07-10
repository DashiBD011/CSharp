using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Account : Person
    {
        private double Balance { get; set; }

        private bool is_acc = false;

        public Message info;
        public Message Error;


        public bool Getacc()
        {
            return is_acc;
        }

        public Account()
        {
            Balance = 0.0;
        }

        public Account(string LastName, string FirstName, uint Age) : base(LastName, FirstName, Age)
        {
            Balance = 0.0;
            is_acc = true;
        }

        public string Info()
        {
            return base.InfoPerson() + $" \nБаланс: {Balance}";
        }

        public void ShowBalance()
        {
            info?.Invoke("Balance:");
        }
         


    }

}

