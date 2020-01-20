using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Calculation.Test
{
    [CollectionDefinition("客户相关")]//这个名字必须和Customer和CustomerDetail这两个类一样，不然Xunit不知道要在什么对象里创建依赖的第三方对象
  public  class CustomerFixtureCollection:ICollectionFixture<CustomerFixture>//上一次是直接船舰fixture，然后哪一个测试对象需要，就直接实现IClassFixture<ClassFixture>
    {
        //这里什么也不用实现，这样，CustomerFixture就可以在CustomerTest和CustomerDetailTest里面被创建实例了。
    }
}
