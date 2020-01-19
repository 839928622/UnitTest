using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculation.Test
{
  public  class CalculatorTest
    {
        [Fact]
        public void Add_GivenTwoIntValues_ReturnInt()
        {
            //创建待测试的对象
            var calculator = new  Calculator();
            var result = calculator.Add(1, 2);
            //期待的值 和 计算的结果比较
            Assert.Equal(3,result);
        }

        [Fact]
        public void AddDouble_GivenTwoDecimalValues_ReturnDecimal()
        {

            //创建待测试的对象
            var calculator = new Calculator();
            var result = calculator.AddDouble(1.2, 2.3);

            //对于decimal或者float，第三个参数填写精度
            //比如精度写1，则期待值和结果值的小数点后的第一个数字会被比较，如3.12，精度1，则去掉3.12中的2
            //，最后再比较
            Assert.Equal(3,result,1);

        }
    }
}
