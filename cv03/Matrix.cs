using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    class Matrix
    {
        double[,] matrix;

        //Matrix constructor, takes matrix as an arg and makes an association with particular instance using "this" keyword
        public Matrix(double[,] matrix)
        {
            this.matrix = matrix;
        }

        //operator implementation via:
        //https://www.dotnetperls.com/operator

        public static Matrix operator +(Matrix a, Matrix b)
        {
            // number of elements in a row
            int row_size = a.matrix.GetLength(0);
            
            // number of elements in a column
            int col_size = a.matrix.GetLength(1);

            //temporary matrix with the same size as matrix "a"
            var tmp = new Matrix(new double[row_size, col_size]);

            //assign addition result to tmp
            for (int i = 0; i < row_size; i++)
            {
                for (int j = 0; j < col_size; j++)
                {
                    tmp.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];                 }
            }
            
            return tmp;
        }


        public static Matrix operator -(Matrix a, Matrix b)
        {
            // number of elements in a row
            int row_size = a.matrix.GetLength(0);

            // number of elements in a column
            int col_size = a.matrix.GetLength(1);

            //temporary matrix with the same size as matrix "a"
            var tmp = new Matrix(new double[row_size, col_size]);

            //assign subtraction result to tmp
            for (int i = 0; i < row_size; i++)
            {
                for (int j = 0; j < col_size; j++)
                {
                    tmp.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                }
            }

            return tmp;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            // number of elements in a row
            int row_size = a.matrix.GetLength(0);

            // number of elements in a column
            int col_size = a.matrix.GetLength(1);

            for (int i = 0; i < row_size; i++)
            {
                for (int j = 0; j < col_size; j++)
                {
                    //compares values at matching coordinates 
                    if (a.matrix[i, j] == b.matrix[i, j])
                        return true;
                }
            }
            return false;
        }

        public static bool operator !=(Matrix a, Matrix b)
        {
            // number of elements in a row
            int row_size = a.matrix.GetLength(0);

            // number of elements in a column
            int col_size = a.matrix.GetLength(1);

            for (int i = 0; i < row_size; i++)
            {
                for (int j = 0; j < col_size; j++)
                {
                    //compares values at matching coordinates 
                    if (a.matrix[i, j] == b.matrix[i, j])
                        return false;
                }
            }
            return true;
        }

        public static Matrix operator -(Matrix a)
        {
            // number of elements in a row
            int row_size = a.matrix.GetLength(0);

            // number of elements in a column
            int col_size = a.matrix.GetLength(1);

            //temporary matrix with the same size as matrix "a"
            var tmp = new Matrix(new double[row_size, col_size]);

            //iterate through the matrix and multiply each element by -1
            for (int i = 0; i < row_size; i++)
            {
                for (int j = 0; j < col_size; j++)
                {
                    tmp.matrix[i, j] = a.matrix[i, j] * (-1);
                }
            }

            return tmp;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            // number of elements in a row
            int row_size = a.matrix.GetLength(0);
            int row_size_b = b.matrix.GetLength(0);

            // number of elements in a column
            int col_size = a.matrix.GetLength(1);

            //temporary matrix with the same size as matrix "a"
            var tmp = new Matrix(new double[row_size, col_size]);

            for (int i = 0; i < row_size; i++)
            {
                for (int j = 0; j < col_size; j++)
                {
                    for (int k = 0; k < row_size_b; k++)
                    {
                        tmp.matrix[i, j] += a.matrix[i, k] * b.matrix[k, j];
                    }
                }
            }
            return tmp;
        }

        public double Determ()
        {
            //TODO
            return 0;
        }

        public override string ToString()
        {
            // number of elements in a column
            int col_size = matrix.GetLength(0);

            // number of elements in a row
            int row_size = matrix.GetLength(1); 

            //printable output
            string printable = "";

            //iteration through the matrix
            for (int i = 0; i < col_size; i++)
            {
                for (int j = 0; j < row_size; j++)
                {
                    printable +=  matrix[i, j] + ", ";
                }

                printable += "\n";
            }

            return printable;
        }
    }
}
