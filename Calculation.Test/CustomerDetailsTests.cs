using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculation.Test
{
    [Collection("客户相关")]
  public  class CustomerDetailsTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerDetailsTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }
    }
}
