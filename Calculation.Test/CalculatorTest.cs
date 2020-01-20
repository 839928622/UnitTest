using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Calculation.Test
{
    public class CalculatorFixture :IDisposable
    {
        public Calculator Calculator => new Calculator();
        public void Dispose()
        {
            //在这里可以写释放资源的逻辑
        }
    }

  public  class CalculatorTest :IClassFixture<CalculatorFixture> //这里会创建XUnit会创建单例的 CalculatorFixture，transident模式 。这么做的好处就是，每一个方法不需要我们再去new 新的对象，浪费资源，每次执行一个test的时候，这个构造函数总是被执行
    {
        private readonly CalculatorFixture _calculatorFixture;
        private readonly ITestOutputHelper _testOutputHelper;

        public CalculatorTest(CalculatorFixture calculatorFixture, ITestOutputHelper testOutputHelper)
        {
            _calculatorFixture = calculatorFixture;
            _testOutputHelper = testOutputHelper;
            _testOutputHelper.WriteLine("构造函数被执行了");
        }

        [Fact]
        public void Add_GivenTwoIntValues_ReturnInt()
        {

            _testOutputHelper.WriteLine("测试是否返回int类型");
            //创建待测试的对象
            var calculator = _calculatorFixture.Calculator;
            var result = calculator.Add(1, 2);
            //期待的值 和 计算的结果比较
            Assert.Equal(3,result);
        }

        [Fact]
        public void AddDouble_GivenTwoDecimalValues_ReturnDecimal()
        {
            _testOutputHelper.WriteLine("测试是否返回decimal类型");
            //创建待测试的对象
            var calculator = new Calculator();
            var result = calculator.AddDouble(1.21, 2.11);

            //对于decimal或者float，第三个参数填写精度
            //比如精度写1，则期待值和结果值的小数点后的第一个数字会被比较，如3.12，精度1，则去掉3.12中的2，
            //做一个四舍五入，如3.12则为3.1，3.5为4
            //，
            Assert.Equal(3.3,result,1);

        }
    }
}
