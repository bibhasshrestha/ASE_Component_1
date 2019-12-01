using FirstComponent;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace UnitTest
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
       
        public void TestMethod1()
        {
            var formA = new Circle();
            var a = formA.r;
            var b = formA.x;
            var c = formA.y;
            formA.ValueSaved(1, 2, 3);
            bool test = false;
            if (a != formA.r && b != formA.x && c!=formA.y)
               test = true;
            Assert.IsTrue(test);
            
        }
    }
}
