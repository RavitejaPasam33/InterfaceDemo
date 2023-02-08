using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer=new Customer();
            customer.GetCustomerInfo();
            Console.WriteLine(customer.GetCustomerId());
            Console.WriteLine(((ICustomer)customer).GetCustomerName());

        }
    }
}
