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
            [Values(1,2,4,7,8,11,13,14)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual(input.ToString(), output);
        }

        [Test]
        public void Buzzer_WhenDivisibleOf3_ReturnsFizz([Values(3,6,9,12)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Fizz", output);
        }

        [Test]
        public void Buzzer_WhenDivisible5_ReturnsBuzz([Values(5, 10)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("Buzz", output);
        }

        [Test]
        public void Buzzer_WhenDivisibleBy3And5_ReturnsBuzz([Values(15)] int input)
        {
            string output = FizzBuzzer.GetValue(input);

            Assert.AreEqual("FizzBuzz", output);
        }
    }
}
