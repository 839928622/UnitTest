using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace Calculation.Test
{
   public class TestCollectionOrder:ITestCollectionOrderer
    {
        public IEnumerable<ITestCollection> OrderTestCollections(IEnumerable<ITestCollection> testCollections)
        {
            return testCollections.OrderBy(x => x.DisplayName);//这里可以对放置了Collection特性的测试类，按什么顺序去执行测试
            //问题：我们可以定义多个类，然后实现ITestCollectionOrderer接口，但是Xunit如何知道对于多个放置了xunit的测试类，怎么作用该排序呢？
            //回答：需要在AssemblyInfo.cs文件里指定，这个文件如果是vs的话，会自动创建，如果没有的话可能需要手动创建。需要Using Xunit，
            // 然后在底部添加这样一条代码：[assembly:TestCollectionOrderer("第一个参数","第二个参数")]
            //其中，第一个参数是我们当前类所在的命名空间，当前类就是TestCollectionOrder，它的命名空间是Calculation.Test，需要把命名空间和类结合起来，
            //那么最终的第一个参数就是：Calculation.Test.TestCollectionOrder,
            //第二个参数，是项目的命名空间，显然，就是Calculation.Test。
        }
    }
}
