using klasaMatrix2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaMatrix2D
{
    public class Matrix2D
    {
        // Prywatne zmienne do przechowywania wartości macierzy
        private readonly int a, b, c, d;

        // Konstruktor z parametrami inicjuje macierz z określonymi wartościami
        public Matrix2D(int a, int b, int c, int d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        // Konstruktor bezparametrowy tworzący macierz identycznościową [1, 0; 0, 1]
        public Matrix2D()
        {
            a = 1;
            b = 0;
            c = 0;
            d = 1;
        }

        // Publiczne właściwości dostępowe do elementów macierzy
        public int A => a;
        public int B => b;
        public int C => c;
        public int D => d;

        // Metoda dodająca dwie macierze
        public Matrix2D Add(Matrix2D other)
        {
            return new Matrix2D(a + other.a, b + other.b, c + other.c, d + other.d);
        }

        // Metoda mnożąca macierz przez skalar
        public Matrix2D Multiply(int scalar)
        {
            return new Matrix2D(a * scalar, b * scalar, c * scalar, d * scalar);
        }
    }
}
