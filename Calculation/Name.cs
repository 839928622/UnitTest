using System;
using System.Collections.Generic;
using System.Text;

namespace Calculation
{
  public  class Name
    {
        public string NikeName { get; set; }
        public string GetFullName(string firstName,string lastName)
        {
            return firstName +" " + lastName;
        }
    }
}
