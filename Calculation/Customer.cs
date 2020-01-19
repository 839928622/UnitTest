using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation
{
   public class Customer
   {
       public string Name => "Alex";
       public int Age  => 35;

       public int GetCustomerAddressNo(string customerName)
       {
           if (string.IsNullOrWhiteSpace(customerName))
           {
               throw new ArgumentNullException();
           }

           return 1;
       }
    }
}
