using Library;
using NUnit.Framework;

namespace Test.Library
{
    public class Tests
    {

        private Car car;


        [SetUp]
        public void Setup()
        {
            car = new Car();
        }

        [Test]
        public void StartCarTest()
        {
            car.StartEngine();
            Assert.True(car.IsOn);
        }

        [Test]
        public void StopCarTest()
        {
            car.StopEngine();
            Assert.False(car.IsOn);
        }

    }
}