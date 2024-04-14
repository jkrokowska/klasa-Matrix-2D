using klasaMatrix2D;

class Program
{
    static void Main(string[] args)
    {
        var matrix1 = new Matrix2D(1, 2, 3, 4);
        var matrix2 = new Matrix2D(5, 6, 7, 8);
        var sum = matrix1.Add(matrix2);
        var product = matrix1.Multiply(10);

        Console.WriteLine($"Sum: [{sum.A}, {sum.B}; {sum.C}, {sum.D}]");
        Console.WriteLine($"Product: [{product.A}, {product.B}; {product.C}, {product.D}]");
    }
}
