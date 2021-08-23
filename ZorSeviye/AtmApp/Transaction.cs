using System;

namespace AtmApp
{
    public class Transaction
    {
        public Transaction()
        {
            this.DateTime = DateTime.Now;
        }

        public DateTime DateTime { get; private set; }
        public string Owner { get; set; }
        public double Amount { get; set; }
        public Operation OperationType { get; set; }
    }

    public enum Operation
    {
        HataliGiris = 1,
        ParaYatirma = 2,
        ParaCekme = 3
    }
}