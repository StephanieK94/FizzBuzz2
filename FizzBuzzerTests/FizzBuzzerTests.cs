using Fizzbuzz.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzerTests.Library
{
    [TestFixture]
    public class FizzBuzzerTests
    {
        [Test]
        public void Buzzer_WhenDefault_ReturnsInput(
            [Values(2)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_When3_ReturnsFizz()
        {
            int input = 3;

            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Fizz", output);
        }
    }
}
