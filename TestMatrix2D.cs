using NUnit.Framework;
using klasaMatrix2D; // Zapewnia dostęp do klasy Matrix2D

namespace TestMatrix2D
{
    [TestFixture]
    public class TestMatrix2D
    {
        [Test]
        public void Add_TwoMatrices_ReturnsCorrectMatrix()
        {
            var matrix1 = new Matrix2D(1, 2, 3, 4);
            var matrix2 = new Matrix2D(5, 6, 7, 8);
            var result = matrix1.Add(matrix2);

            Assert.AreEqual(6, result.A);
            Assert.AreEqual(8, result.B);
            Assert.AreEqual(10, result.C);
            Assert.AreEqual(12, result.D);
        }

        [Test]
        public void Multiply_MatrixByScalar_ReturnsCorrectMatrix()
        {
            var matrix = new Matrix2D(1, 2, 3, 4);
            var result = matrix.Multiply(2);

            Assert.AreEqual(2, result.A);
            Assert.AreEqual(4, result.B);
            Assert.AreEqual(6, result.C);
            Assert.AreEqual(8, result.D);
        }
    }
}
