using System;

namespace AtmApp
{
    public class Transaction
    {
        public Transaction()
        {
            this.DateTime = DateTime.Now;
        }

        public Transaction(Operation operationType)
        {
            this.DateTime = DateTime.Now;
            this.OperationType = operationType;
        }

        public Transaction(string owner, Operation operationType)
        {
            this.DateTime = DateTime.Now;
            this.Owner = owner;
            this.OperationType = operationType;
        }

        public DateTime DateTime { get; private set; }
        public string Owner { get; set; }
        public double Amount { get; set; }
        public Operation OperationType { get; set; }
    }

    public enum Operation
    {
        HataliGiris = 1,
        BasariliGiris = 2,
        ParaYatirma = 3,
        ParaCekme = 4
    }
}