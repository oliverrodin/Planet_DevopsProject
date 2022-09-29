using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Planet_DevopsProject.NUnitTest
{
    [TestFixture]
    public class MathTest
    {
        private Calculation _math;

        [SetUp]
        public void SetUp()
        {
            _math = new Calculation();
        }
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            
            var result = _math.Addition(1, 2);

            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Subtract_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Subtraction(3, 2);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Multiply_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Multiplication(2, 2);

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Divide_WhenCalled_ReturnTheSumOfArguments()
        {
            var result = _math.Division(4, 2);

            Assert.That(result, Is.EqualTo(2));
        }
    }
}
