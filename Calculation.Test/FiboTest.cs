using System.Collections.Generic;
using Xunit;

namespace Calculation.Test
{
    public class FiboTest
    {
        [Fact]
        [Trait("类别","斐波那契数列")]
        public void FiboNumbersNotContainsZero()
        {
            var fibo = new Fibo();
            Assert.All(fibo.fiboNumbers, n => Assert.NotEqual(0,n));//对集合遍历，对某一个元素进行测试
        }

        [Fact] //斐波那契数列必须包含13
        [Trait("类别", "斐波那契数列")]
        public void FiboMustContains13()
        {
            var fibo = new Fibo();
            Assert.Contains(13, fibo.fiboNumbers);//后者包含前者
        }

        [Fact]
        [Trait("类别", "斐波那契数列")]
        public void FiboNotContains4()
        {
            var fibo = new Fibo();
             Assert.DoesNotContain(4,fibo.fiboNumbers);//后者不包含前者
        }

        [Fact]
        public void FiboCollectionTest()
        {
            var fiboList = new List<int>() { 1, 1, 2, 3, 5, 8, 13, 21 };
            var fibo = new Fibo();
            Assert.Equal(fiboList,fibo.fiboNumbers);//两个集合是否相等

        }
    }
}
