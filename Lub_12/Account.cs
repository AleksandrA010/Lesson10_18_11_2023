using System;

namespace Lub_12
{
    public class Account
    {
        private static int _staticAccountNumber = 102200;
        private int _accountNumber;
        private double _balance;
        private string _fullName;
        private string _accountType;
        public string AccountType { get { return _accountType; } }
        public int AccountNumber { get { return _accountNumber; } }
        public double Balance { get { return _balance; } }
        public string FullName { get { return _fullName; } }

        public Account(string fullName, string accountType)
        {
            _accountNumber = _staticAccountNumber++;
            _balance = 0;
            _fullName = fullName;
            _accountType = accountType;
        }
        public static bool operator ==(Account left, Account right)
        {
            if (left._accountType == right.AccountType)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Account left, Account right)
        {
            if (left._accountType != right.AccountType)
            {
                return true;
            }
            return false;
        }
        public override bool Equals(object obj)
        {
            if (obj is Account account)
            {
                return AccountType == account.AccountType;
            }
            return false;
        }
        public override int GetHashCode()
        {
            return AccountType.GetHashCode();
        }
        public override string ToString()
        {
            return $"Номер счёта — {AccountNumber}\n" +
                $"Владелец — {FullName}\n" +
                $"Баланс — {Balance}";
        }
        public void Deposit(double money)
        {
            if (money < 0)
            {
                Console.WriteLine("\nОшибка!\nВы пытаетесь положить отрицательную сумму!");
            }
            else
            {
                _balance += money;
            }
        }
        public void Withdraw(double money)
        {
            if (money < 0)
            {
                Console.WriteLine("\nОшибка!\nВы пытаетесь взять отрицательную сумму!");
            }
            else if (money > 0)
            {
                Console.WriteLine("\nНа вашем счёте не достаточно средств!");
            }
            else
            {
                _balance -= money;
            }
        }
    }
}
