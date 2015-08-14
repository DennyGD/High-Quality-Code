namespace Matrix.Tests
{
    using System;

    using MatrixRefactoring;
    using NUnit.Framework;

    [TestFixture]
    public class SquareMatrixTests
    {
        [Test]
        public void ExpectToContainTheDigitOneWhenSizeIsOne()
        {
            var matrix = new SquareMatrix(1);
            Assert.AreEqual(1, matrix[0, 0], string.Format("Instead of 1, the matrix contains {0}.", matrix[0, 0]));
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExpectToThrowWhenSizeIsZero()
        {
            var matrix = new SquareMatrix(0);
        }

        [Test]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ExpectToThrowWhenSizeIs101()
        {
            var matrix = new SquareMatrix(101);
        }

        [Test]
        public void ExpectNotToThrowWhenSizeIs100()
        {
            var matrix = new SquareMatrix(100);
        }

        [Test]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ExpectToThrowWhenIndicesAreEqualToSize()
        {
            int size = 4;
            var matrix = new SquareMatrix(size);
            int number = matrix[size, size];
        }

        [Test]
        public void ExpectWhenSizeIs6ToHaveACorrectMatrix()
        {
            var matrix = new SquareMatrix(6);
            int expectedTwenty = matrix[0, 5];
            int expectedThirtySix = matrix[3, 1];
            int expectedSix = matrix[5, 5];
            int expectedThirty = matrix[2, 4];

            bool isCorrect = (expectedTwenty == 20) && (expectedThirtySix == 36) && (expectedSix == 6)
                && (expectedThirty == 30);

            Assert.IsTrue(isCorrect, "Numbers 20, 36, 6 and 30 are not found where they were expected.");
        }
    }
}
