using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] matrixA = 
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };

            double[,] matrixB =
            {
                { 4, 4, 0 },
                { 2, 7, 8 },
                { 1, 2, 6 }
            };
            
            Matrix mA = new Matrix(matrixA);
            Matrix mB = new Matrix(matrixB);

            Console.WriteLine("Matrix A:\n" + mA);
            Console.WriteLine("Matrix B:\n" + mB + "--------------------");

            //addition
            Console.WriteLine("Addition:\n");
            Console.WriteLine(mA + mB + "--------------------");

            //subtraction
            Console.WriteLine("Subtraction:\n");
            Console.WriteLine(mA - mB + "--------------------");

            //equality
            Console.WriteLine("Equality:\n");
            Console.WriteLine(mA == mB);
            Console.WriteLine("--------------------");

            //inequality
            Console.WriteLine("Inequality:\n");
            Console.WriteLine(mA != mB);
            Console.WriteLine("--------------------");

            //inverse elements (not inverse matrix)
            Console.WriteLine("Inverse elements:\n");
            Console.WriteLine(-mA + "--------------------");

            //multiplication
            Console.WriteLine("Multiplication:\n");
            Console.WriteLine(mA * mB + "--------------------");
            
            Console.ReadLine();
        }
    }
}
