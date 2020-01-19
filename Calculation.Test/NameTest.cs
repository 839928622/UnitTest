using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculation.Test
{
  public  class NameTest
    {
        [Fact]

        public void GetFullName_InputFirstNameAndLastName_ReturnFullName()
        {
            var name = new Name();
          var res=  name.GetFullName("leo", "packer");
          Assert.Equal("leo packer",res,ignoreCase:true);
          Assert.Contains("leo", res);
          Assert.StartsWith("l",res);
          Assert.Matches("[a-z][a-z]",res);//可以使用正则表达式
          Assert.True(!string.IsNullOrWhiteSpace(res));//可以判断是否是空字串或者null  Assert.True返回true才会通过
          Assert.False(string.IsNullOrWhiteSpace(res));//上面的可读性比较差，换成21行，结果为false，则通过
        }

        [Fact]
        public void NikeNameMustBeNull()
        {
            var name = new Name();
            Assert.Null(name.NikeName);
        }
    }
}
