using FirstComponent;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class UnitTestDrawTo
    {
        [TestMethod]
        public void PenDraw()
        {
            var formA = new FormMain();
            var x = formA.positionX;
            var y = formA.positionY;
            formA.DrawPen(10, 10);
            bool ex = false;
            if (x!= formA.positionX && y!= formA.positionY)
                ex = true;
            Assert.IsTrue(ex);
        }
    }
}
