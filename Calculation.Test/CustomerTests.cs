using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculation.Test
{
    [Collection("客户相关")] //我们假装他是计算器类
  public  class CustomerTests
    {
        private readonly CustomerFixture _customerFixture;

        public CustomerTests(CustomerFixture customerFixture)
        {
            _customerFixture = customerFixture;
        }

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

        [Fact]
        public void GetCustomerAddressNoByNameNull()
        {
            var customer = new Customer();
            Assert.Throws<ArgumentNullException>(() => customer.GetCustomerAddressNo(null));//判断是否会抛出异常

            var exception = Assert.Throws<ArgumentNullException>(() => customer.GetCustomerAddressNo(null));//可以获取异常里的消息
             Assert.Equal("customerName", exception.ParamName);   
        }

        [Fact]
        public void OverrideMethodCheck()
        {
            var customer = new Customer();
            Assert.Equal(1,customer.GetCustomerAddressNo("你好"));//说明实例化父类，执行的还是父类的方法。
        }

        [Fact]
        public void CustomerReturnTypeCheckWhenOrderCountGreaterThan100()
        {
            Assert.IsType<LoyalCustomer>(CustomerFactory.CreateCustomerInstance(122));//检验对象（object）的类型
           // Assert.IsType(typeof(LoyalCustomer),CustomerFactory.CreateCustomerInstance(102));//这里不建议使用typeof去检查 对象的类型
        }
    }
}
