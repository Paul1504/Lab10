using VehicleLibrary1;
namespace TestLibrary1
{
    [TestClass]
    public class CarTest
    {
        Car car;

        [TestInitialize]
        public void Setup()
        {
            car = new Car();
        }

        [TestMethod]
        public void TestSeatCount()
        {
            car.SeatCount = 5;
            Assert.AreEqual(5, car.SeatCount);
        }

        [TestMethod]
        public void TestMaxSpeed()
        {
            car.MaxSpeed = 200;
            Assert.AreEqual(200, car.MaxSpeed);
        }

        [TestMethod]
        public void TestRandomInit()
        {
            car.RandomInit();
            Assert.IsTrue(car.SeatCount >= 2 && car.SeatCount <= 7); 
            Assert.IsTrue(car.MaxSpeed >= 100 && car.MaxSpeed <= 300); 
        }

        [TestMethod]
        public void TestShowAndToStringMethods()
        {
            car = new Car("Toyota", 2010, "Red", 15000, 10, new IdNumber(123), 5, 200); 
            string expected = "Модель = Toyota, Год выпуска = 2010, Цвет = Red, Стоимость = 15000, Дорожный просвет = 10, Количество мест = 5, Максимальная скорость(в км/ч): 200";

            Assert.AreEqual(expected, car.ToString());
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            Car car1 = new Car("Toyota", 2010, "Red", 15000, 10, new IdNumber(123), 5, 200);
            Car car2 = new Car("Toyota", 2011, "Blue", 20000, 10, new IdNumber(124), 5, 200);
            Car car3 = new Car("Toyota", 2010, "Red", 15000, 10, new IdNumber(123), 5, 200);

            Assert.IsTrue(car1.Equals(car2)); 
            Assert.AreEqual(car1,car3); 
        }
    }
}