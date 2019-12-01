using FirstComponent;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{ 
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]
            public void TestMethod1()
            {
                var formA = new Triangle();
                var a = formA.x;
                var b = formA.y;
                var c = formA.CircleBase;
                var d = formA.CirclePer;
            
                formA.SavedValues(5, 3, 1, 4);
                bool test = false;
                if (a != formA.x && b != formA.y && c != formA.CircleBase &&d!=formA.CirclePer)
                test = true;
                Assert.IsTrue(test); 
        }
    }
}

 

