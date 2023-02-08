using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    internal interface ICustomer
    {
        public string GetCustomerName()
        {
            return "Geetha";
        }
        void GetCustomerInfo();
    }
    class Customer : ICustomer
    {
        public int GetCustomerId() 
        {
            return 103;

        }
    }
    public void GetCustomerInfo()
    {
        Console.WriteLine("get customer info from interface implemented in customer class");
    }


}
