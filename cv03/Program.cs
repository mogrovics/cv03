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
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 },
            };
            
            Matrix mA = new Matrix(matrixA);
            Matrix mB = new Matrix(matrixB);
            
            //addition
            Console.WriteLine(mA + mB);

            //subtraction
            Console.WriteLine(mA - mB);

            //
            Console.WriteLine(-mA);
            
            Console.ReadLine();
        }
    }
}
