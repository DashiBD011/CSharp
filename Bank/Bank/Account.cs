using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Console;
namespace Bank
{
    [Serializable]
    public class Account : Person
    {
        private double Balance { get; set; }
        [NonSerialized]
        private bool is_acc = false;

        public Message info;
        public Message Error;
        public Readline readline;
        BinaryFormatter formatter = new BinaryFormatter();
      
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

        public void WriteToFile()
        {
            using (var fs = new FileStream("account.bin",FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, this);
            }
        }
        public Account ReadFromFile()
        {
            Account newAcc;
            using (var fs = new FileStream("account.bin",FileMode.OpenOrCreate))
            {
                newAcc = (Account)formatter.Deserialize(fs);
            }
            return newAcc;
        }
        public void DeleteAcc()
        {
            using (var fs = new FileStream("account.bin", FileMode.Truncate))
            {
                info("Аккаунт удален");
            }
        }
        public void TopUp()
        {
            info("Введите сумму ");
            uint sum = UInt32.Parse(ReadLine());
            Balance += sum;

        }
        public void Withdraw()
        {
            info("Введите сумму");
            uint sum = UInt32.Parse(ReadLine());
            if (Balance >= sum)
            {
                Balance -= sum;
                info("Успешно");
            }
            else Error("На счете недостаточно средств");
        }
    }

}

