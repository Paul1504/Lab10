using VehicleLibrary1;
namespace TestLibrary1
{
    [TestClass]
    public class VehicleTest
    {
        Vehicle vehicle;

        [TestInitialize]
        public void Setup()
        {
            vehicle = new Vehicle();
        }

        [TestMethod]
        public void TestBrand()
        {
            vehicle.Brand = "Toyota";
            Assert.AreEqual("Toyota", vehicle.Brand);
        }

        [TestMethod]
        public void TestYear()
        {
            vehicle.Year = 2010;
            Assert.AreEqual(2010, vehicle.Year);
        }

        [TestMethod]
        public void TestColor()
        {
            vehicle.Color = "Red";
            Assert.AreEqual("Red", vehicle.Color);
        }

        [TestMethod]
        public void TestPrice()
        {
            vehicle.Price = 15000;
            Assert.AreEqual(15000, vehicle.Price);
        }

        [TestMethod]
        public void TestGroundClearance()
        {
            vehicle.GroundClearance = 10;
            Assert.AreEqual(10, vehicle.GroundClearance);
        }


        [TestMethod]
        public void TestRandomInitMethod()
        {
            vehicle.RandomInit(); 
            Assert.IsFalse(string.IsNullOrEmpty(vehicle.Brand));
            Assert.IsTrue(vehicle.Year >= 2001 && vehicle.Year <= 2023); 
            Assert.IsFalse(string.IsNullOrEmpty(vehicle.Color));
            Assert.IsTrue(vehicle.Price >= 10000 && vehicle.Price <= 500000); 
            Assert.IsTrue(vehicle.GroundClearance >= 5 && vehicle.GroundClearance <= 15); 
        }
        [TestMethod]
        public void TestCloneMethod()
        {
            var clonedVehicle = (Vehicle)vehicle.Clone();
            Assert.AreEqual(vehicle.ToString(), clonedVehicle.ToString());
        }

        [TestMethod]
        public void TestShallowCopyMethod()
        {
            var shallowCopy = vehicle.ShallowCopy();
            Assert.AreEqual(vehicle.ToString(), shallowCopy.ToString());
        }
    }
}