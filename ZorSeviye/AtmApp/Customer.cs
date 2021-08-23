using System.Collections.Generic;

namespace AtmApp
{
    public class Customer
    {
        public Customer(string fullName, short password, double balance)
        {
            this.FullName = fullName;
            this.Password = password;
            this.Balance = balance;
        }

        public string FullName { get; set; }
        public short Password { get; set; }
        public double Balance { get; set; }
    }

    public static class CustomerDataSource
    {
        static CustomerDataSource()
        {
            CustomerList = FillCustomer();
        }
        public static List<Customer> CustomerList { get; set; }

        private static List<Customer> FillCustomer()
        {
            return new List<Customer>()
            {
                new Customer("Ali Aydın", 3428, 3750.20),
                new Customer("Fatih Yılmaz", 1192, 1412.78),
                new Customer("Hatice Onur", 7854, 2312.34),
                new Customer("Hasan Taner", 4725, 2010.42)
            };
        }
    }
}