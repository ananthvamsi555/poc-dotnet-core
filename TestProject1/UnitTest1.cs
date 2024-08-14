using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var obj = new Class1();
            var result = obj.Add(1, 1);
            Assert.AreEqual(2, result);
        }
        [TestMethod]
        public void TestMethod2()
        {
            var obj = new Class1();
            var result = obj.Multiply(1, 1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod3()
        {
            var obj = new Class1();
            var result = obj.Test(1, 1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod4()
        {
            var obj = new Class1();
            var result = obj.Test2(1, 1);
            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void TestMethod5()
        {
            var obj = new Class1();
            var result = obj.Test3(1, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestMethod6()
        {
            var obj = new Class1();
            var result = obj.Test4(1, 1);
            Assert.AreEqual(1, result);
        }
    }
}
