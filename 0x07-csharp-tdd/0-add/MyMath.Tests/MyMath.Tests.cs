using NUnit.Framework;
using MyMath;

namespace Tests
{
    [TestFixture]
    public class MyMath_Tests
    {
        [Test]
        public void AddIntegers0(){
            int result = Operations.Add(1,2);
            Assert.AreEqual(3, result);
        }
         [Test]
        public void AddIntegers1(){
            int result = Operations.Add(1,1);
            Assert.AreEqual(2, result);
        }
         [Test]
        public void AddIntegers2(){
            int result = Operations.Add(5,2);
            Assert.AreEqual(7, result);
        }
         [Test]
        public void AddIntegers3(){
            int result = Operations.Add(6,2);
            Assert.AreEqual(8, result);
        }
         [Test]
        public void AddIntegers4(){
            int result = Operations.Add(7,2);
            Assert.AreEqual(9, result);
        }
         [Test]
        public void AddIntegers5(){
            int result = Operations.Add(10,2);
            Assert.AreEqual(12, result);
        }
         [Test]
        public void AddIntegers6(){
            int result = Operations.Add(122,2);
            Assert.AreEqual(124, result);
        }
         [Test]
        public void AddIntegers7(){
            int result = Operations.Add(0,2);
            Assert.AreEqual(2, result);
        }
    }
}