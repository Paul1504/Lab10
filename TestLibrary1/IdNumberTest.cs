using VehicleLibrary1;
namespace TestLibrary1
{
    [TestClass]
    public class IdNumberTest
    {
        IdNumber idNumber;

        [TestInitialize]
        public void Setup()
        {
            idNumber = new IdNumber(123);
        }

        [TestMethod]
        public void TestNumberProperty()
        {
            Assert.AreEqual(123, idNumber.Number);
        }

        [TestMethod]
        public void TestEqualsMethod()
        {
            IdNumber idNumber1 = new IdNumber(123);
            IdNumber idNumber2 = new IdNumber(456);
            IdNumber idNumber3 = new IdNumber(123);

            Assert.IsFalse(idNumber1.Equals(idNumber2)); 
            Assert.IsTrue(idNumber1.Equals(idNumber3)); 
        }

        [TestMethod]
        public void TestToStringMethod()
        {
            Assert.AreEqual("123", idNumber.ToString());
        }
    }
}