using VehicleLibrary1;
namespace TestLibrary1
{
    [TestClass]
    public class SortByPriceTest
    {
        SortByPrice sortByPrice;

        [TestInitialize]
        public void Setup()
        {
            sortByPrice = new SortByPrice();
        }

        [TestMethod]
        public void TestCompareMethod1()
        {
            Vehicle car1 = new Vehicle("Toyota", 2010, "Red", 15000, 10, new IdNumber(123));
            Vehicle car2 = new Vehicle("BMW", 2005, "Black", 10000, 5, new IdNumber(124));
            int result1 = sortByPrice.Compare(car1, car2);
            Assert.AreEqual(1, result1);
        }
        [TestMethod]
        public void TestCompareMethod2()
        {
            Vehicle car1 = new Vehicle("Toyota", 2010, "Red", 15000, 10, new IdNumber(123));
            Vehicle car2 = new Vehicle("BMW", 2005, "Black", 10000, 5, new IdNumber(124));
            int result2 = sortByPrice.Compare(car2, car1);
            Assert.AreEqual(-1, result2);
        }
        public void TestCompareMethod3()
        {
            Vehicle car1 = new Vehicle("Toyota", 2010, "Red", 15000, 10, new IdNumber(123));
            Vehicle car3 = new Vehicle("Toyota", 2010, "Red", 15000, 10, new IdNumber(123));
            int result3 = sortByPrice.Compare(car1, car3);
            Assert.AreEqual(0, result3);
        }
    }
}
