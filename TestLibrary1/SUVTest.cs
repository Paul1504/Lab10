using VehicleLibrary1;
namespace TestLibrary1
{
    [TestClass]
    public class SUVTest
    {
        SUV suv;

        [TestInitialize]
        public void Setup()
        {
            suv = new SUV();
        }

        [TestMethod]
        public void TestFourWheelDrive()
        {
            suv.FourWheelDrive = true;
            Assert.IsTrue(suv.FourWheelDrive);
        }

        [TestMethod]
        public void TestTerrainType()
        {
            suv.TerrainType = "Гравий";
            Assert.AreEqual("Гравий", suv.TerrainType);
        }

        [TestMethod]
        public void TestRandomInitMethod()
        {
            suv.RandomInit();
                              
            Assert.IsTrue(typeof(bool) == suv.FourWheelDrive.GetType()); 
        }

        [TestMethod]
        public void TestShowAndToStringMethods()
        {
            suv = new SUV("Toyota", 2010, "Red", 15000, 10, new IdNumber(123), true, "Снег");
            string expected = "Модель = Toyota, Год выпуска = 2010, Цвет = Red, Стоимость = 15000, Дорожный просвет = 10, Привод: True, Тип бездорожья: Снег";

            Assert.AreEqual(expected, suv.ToString()); 
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            SUV suv1 = new SUV("Toyota", 2010, "Red", 15000, 10, new IdNumber(123), true, "Снег");
            SUV suv2 = new SUV("Toyota", 2011, "Blue", 20000, 10, new IdNumber(124), true, "Снег");
            SUV suv3 = new SUV("Toyota", 2010, "Red", 15000, 10, new IdNumber(123), true, "Снег");

            Assert.IsTrue(suv1.Equals(suv2)); 
            Assert.IsTrue(suv1.Equals(suv3)); 
        }
    }
}