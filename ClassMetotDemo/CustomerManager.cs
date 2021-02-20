using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer newCostomer)
        {
            Console.WriteLine("Name:" + newCostomer.Name+ " " + "Surname:" + newCostomer.Surname + " " + "Id:" +newCostomer.Id + " " + "CustomerNo:" + newCostomer.CustomerNo);
            Console.WriteLine("Added a new customer");
        }

        public void Delete(Customer oldCustomer)
        {
            Console.WriteLine("Name:" + oldCustomer.Name + " " + "Surname:" + oldCustomer.Surname + " " + "Id:" + oldCustomer.Id + " " + "CustomerNo:\n" + oldCustomer.CustomerNo);
            Console.WriteLine("Deleted an old customer");
        }

        public void List(Customer list)
        {
            Console.WriteLine("Name:" + list.Name + " " + "Surname:" + list.Surname + " " + "Id:" + list.Id + " " + "CustomerNo:" + list.CustomerNo);
            Console.WriteLine("Customer listed");
        }
       
    }
}
