using CalculatorPrj;

namespace CalcTest
{
    public class Tests
    {
        //Declarations
        ICalculator obj;

        //Annotations - [] for compiler to know 
        [SetUp]
        public void Setup()
        {
            obj = new Calculator();
        }

        [Test]
        public void TestAdd()
        {
            //3A's - Assign, Act and Assert
            int actualresult=obj.add(4, 5);
            int expectedresult = 10;
            Assert.AreEqual(expectedresult, actualresult);
        }

        [Test]
        public void TestMul()
        {
            //3A's - Assign, Act and Assert
            int actualresult = obj.multiply(4, 5);
            int expectedresult = 20;
            Assert.AreEqual(expectedresult, actualresult);
        }

        [Test]
        public void TestMessage()
        {
            string actualres = obj.message("Ram");
            Assert.AreEqual("Hello Ram", actualres);
        }

        [Test]
        public void TestInc()
        {
            int res = obj.inc(4);
            Assert.AreEqual(res, 5);
        }
        [Test]
        public void TestCheckAgetrue()
        {
            bool res = obj.checkAge(20);
            Assert.AreEqual(res, true);
        }

        [Test]
        public void TestCheckAgefalse()
        {
            bool res = obj.checkAge(4);
            Assert.AreEqual(res, false);
        }

    }
}