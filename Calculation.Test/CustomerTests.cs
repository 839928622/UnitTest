using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculation.Test
{
  public  class CustomerTests
    {
        [Fact]
        public void CheckNameNotEmpty()
        {
            var customer = new Customer();
            Assert.NotNull(customer.Name);
            Assert.False(string.IsNullOrWhiteSpace(customer.Name));//验证性命不能为空
        }

        [Fact]
        public void CheckAgeForDiscount()
        {
            var  customer = new  Customer();
            Assert.InRange(customer.Age,25,40);//数值是否在该范围 年龄默认值是35
            Assert.InRange(customer.Age, 35, 35);// 这个是大于等于且小于等于的关系
        }
    }
}
