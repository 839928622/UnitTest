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
        }
    }
}
