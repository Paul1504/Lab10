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
            suv.TerrainType = "������";
            Assert.AreEqual("������", suv.TerrainType);
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
            suv = new SUV("Toyota", 2010, "Red", 15000, 10, new IdNumber(123), true, "����");
            string expected = "������ = Toyota, ��� ������� = 2010, ���� = Red, ��������� = 15000, �������� ������� = 10, ������: True, ��� ����������: ����";

            Assert.AreEqual(expected, suv.ToString()); 
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            SUV suv1 = new SUV("Toyota", 2010, "Red", 15000, 10, new IdNumber(123), true, "����");
            SUV suv2 = new SUV("Toyota", 2011, "Blue", 20000, 10, new IdNumber(124), true, "����");
            SUV suv3 = new SUV("Toyota", 2010, "Red", 15000, 10, new IdNumber(123), true, "����");

            Assert.IsTrue(suv1.Equals(suv2)); 
            Assert.IsTrue(suv1.Equals(suv3)); 
        }
    }
}