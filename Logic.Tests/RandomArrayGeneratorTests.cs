using System;
using System.Linq;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class RandomArrayGeneratorTests
    {
        [TestCase(1234)]
        [TestCase(3)]
        [TestCase(357235)]
        [TestCase(121)]
        [TestCase(12112354)]
        public void GetRandomArray_FirstMethod_NormalCount(int count)
        {
            var result = RandomArrayGenerator.GetRandomArray1(count);
            var sum = result.Sum();

            Assert.IsFalse(sum > 1 || sum < 1);
        }

        [TestCase(3575)]
        [TestCase(121)]
        [TestCase(12112)]
        public void GetRandomArray_FirstMethod_CheckAllElements(int count)
        {
            var result = RandomArrayGenerator.GetRandomArray1(count);

            foreach (var number in result)
            {
                Assert.IsTrue(number > 0 || number < 1);
            }
        }

        [TestCase(0)]
        [TestCase(-100)]
        public void GetRandomArray_FirstMethod_InvalidCount_ArgumentException(int count)
        {
            Assert.Catch<ArgumentException>(() => RandomArrayGenerator.GetRandomArray1(count));
        }

        [TestCase(1234)]
        [TestCase(124234)]
        [TestCase(3)]
        [TestCase(35732235)]
        [TestCase(1231)]
        public void GetRandomArray_SecondMethod_NormalCount(int count)
        {
            var result = RandomArrayGenerator.GetRandomArray2(count);
            var sum = result.Sum();

            Assert.IsFalse(sum > 1 || sum < 1);
        }

        [TestCase(3575)]
        [TestCase(121)]
        [TestCase(12112)]
        public void GetRandomArray_SecondMethod_CheckAllElements(int count)
        {
            var result = RandomArrayGenerator.GetRandomArray2(count);

            foreach (var number in result)
            {
                Assert.IsTrue(number > 0 || number < 1);
            }
        }

        [TestCase(0)]
        [TestCase(-100)]
        public void GetRandomArray_SecondMethod_InvalidCount_ArgumentException(int count)
        {
            Assert.Catch<ArgumentException>(() => RandomArrayGenerator.GetRandomArray2(count));
        }
    }
}
