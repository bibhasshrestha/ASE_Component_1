using FirstComponent;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTest
{
    [TestClass]
    public class UnitTestMoveTo
    {
        [TestMethod]
        public void MovePen()
        {
            var formA = new FormMain();
            var x = formA.positionX;
            var y = formA.positionY;
            formA.PenMove(10, 10);
            bool ex = false;
            if (x != formA.positionX && y != formA.positionY)
                ex = true;
            Assert.IsTrue(ex);

        }
    }
}
