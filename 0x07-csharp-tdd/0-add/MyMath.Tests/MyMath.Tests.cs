using NUnit.Framework;
using MyMath;

namespace Tests
{
    [TestFixture]
    public class MyMath_Tests
    {
        [Test]
        public void AddIntegers(){
            int result = Operations.Add(1,2);
            Assert.AreEqual(3, result);
        }
    }
}