using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Customer Information");


            MyDictionary<int, string> customerInformation = new MyDictionary<int, string>();
            
            customerInformation.Add(1, "Büşra Bulut");
            customerInformation.Add(2, "Hasret Kalhan");
            customerInformation.Add(3, "Ece Umuc");
            customerInformation.Add(4, "Elif Kaya");
            customerInformation.Add(5, "Selin Vatansever");
           
            customerInformation.List();
            
            Console.WriteLine("The number of customers");
            Console.WriteLine(customerInformation.Count);

        }


    }


}