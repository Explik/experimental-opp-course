using System;

namespace Lecture_8_Solutions
{
    public delegate void BalanceChangeHandler(decimal currentBalance);

    public class BankAccount
    {
        private decimal _balance;
        private decimal _lowBalanceThreshold;
        private decimal _highBalanceThreshold;

        public event BalanceChangeHandler LowBalance;

        public event BalanceChangeHandler HighBalance;

        public decimal Balance
        {
            get { return _balance; }
            private set
            {
                _balance = value;

                if (value <= LowBalanceThreshold)
                    LowBalance?.Invoke(value);
                if (value >= HighBalanceThreshold)
                    HighBalance?.Invoke(value);
            }
        }

        public decimal LowBalanceThreshold
        {
            get { return _lowBalanceThreshold; }
            set
            {
                if (value > HighBalanceThreshold)
                    throw new ArgumentException();
                _lowBalanceThreshold = value;
            }
        }

        public decimal HighBalanceThreshold
        {
            get { return _highBalanceThreshold; }
            set
            {
                if (value < LowBalanceThreshold)
                    throw new ArgumentException();
                _highBalanceThreshold = value;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException();
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount < 0)
                throw new ArgumentException();
            Balance -= amount;
        }
    }
}