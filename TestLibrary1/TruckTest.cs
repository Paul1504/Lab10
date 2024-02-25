using VehicleLibrary1;
namespace TestLibrary1
{
    [TestClass]
    public class TruckTest
    {
        Truck truck;

        [TestInitialize]
        public void Setup()
        {
            truck = new Truck();
        }

        [TestMethod]
        public void TestLoadCapacity()
        {
            truck.LoadCapacity = 5;
            Assert.AreEqual(5, truck.LoadCapacity);
        }

        [TestMethod]
        public void TestRandomInitMethod()
        {
            truck.RandomInit(); 
            Assert.IsTrue(truck.LoadCapacity >= 1 && truck.LoadCapacity <= 10);
        }

     
        [TestMethod]
        public void TestEqualsMethod()
        {
            Truck truck1 = new Truck("Volvo", 2015, "Blue", 25000, 15, new IdNumber(456), 8);
            Truck truck2 = new Truck("Volvo", 2016, "Red", 30000, 15, new IdNumber(457), 8);
            Truck truck3 = new Truck("Volvo", 2015, "Blue", 25000, 15, new IdNumber(456), 8);

            Assert.IsTrue(truck1.Equals(truck2)); 
            Assert.IsTrue(truck1.Equals(truck3)); 
        }
    }
}