using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation
{
   public class Customer
   {
       public string Name => "Alex";
       public int Age  => 35;

       public virtual int GetCustomerAddressNo(string customerName)
       {
           if (string.IsNullOrWhiteSpace(customerName))
           {
               throw new ArgumentNullException(nameof(customerName));
           }

           return 1;
       }
    }


   public class LoyalCustomer:Customer
   {
       public LoyalCustomer()
       {
           Discount = 10;
       }
       public int Discount { get; set; }

       public override int GetCustomerAddressNo(string customerName)
       {
           return 102;
       }
   }


   public static class CustomerFactory
   {
       public static Customer CreateCustomerInstance(int orderCount)
       {
           return orderCount > 100 ? new LoyalCustomer() : new Customer();
       }
   }
}
