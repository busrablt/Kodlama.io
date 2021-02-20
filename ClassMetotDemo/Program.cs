using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Büşra";
            customer1.Surname = "Bulut";
            customer1.CustomerNo = 2104;

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Hasret";
            customer2.Surname = "Kalhan";
            customer2.CustomerNo = 1608;

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Elif";
            customer3.Surname = "Kaya";
            customer3.CustomerNo = 2804;

            CustomerManager customerManager = new CustomerManager();
            Customer[] customers = new Customer[] { customer1, customer2, customer3 };

            foreach (Customer customer in customers)
            {
                customerManager.List(customer);
            }

            customerManager.Add(customer3);
            customerManager.Delete(customer1);


        }
    }
}
