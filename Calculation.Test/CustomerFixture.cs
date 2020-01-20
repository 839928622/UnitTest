namespace Calculation.Test
{
   public class CustomerFixture //主要用于为CustomerTests和CustomerDetailsTests这两个对象，
    {
        public Customer Customer => new Customer();//这里new 依赖的待测试的对象
    }
}
