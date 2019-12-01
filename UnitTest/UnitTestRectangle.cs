using FirstComponent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class UnitTestRectangle
    {
        [TestMethod]

        public void TestMethod1()
        {
            var formA = new Rectangle();
            var a = formA.x;
            var b = formA.y;
            var c = formA.z;
            var d = formA.h;
            formA.saved_values(1, 2, 1, 2);
            bool test = false;
            if (a != formA.x && b != formA.y && c != formA.z && d != formA.h)
                test = true;
            Assert.IsTrue(test);
        }
    }
}
