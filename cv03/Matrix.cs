using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv03
{
    public class Matrix
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
            // number of elements in a column
            int col_size = a.matrix.GetLength(0);
            
            // number of elements in a row
            int row_size = a.matrix.GetLength(1);

            //temporary result matrix with the same size as matrix "a"
            var tmp = new Matrix(new double[col_size, row_size]);

            //assign addition result to tmp
            for (int i = 0; i < col_size; i++)
            {
                for (int j = 0; j < row_size; j++)
                {
                    tmp.matrix[i, j] = a.matrix[i, j] + b.matrix[i, j];                 }
            }
            
            return tmp;
        }


        public static Matrix operator -(Matrix a, Matrix b)
        {
            // number of elements in a column
            int col_size = a.matrix.GetLength(0);

            // number of elements in a row
            int row_size = a.matrix.GetLength(1);

            //temporary result matrix with the same size as matrix "a"
            var tmp = new Matrix(new double[col_size, row_size]);

            //assign addition result to tmp
            for (int i = 0; i < col_size; i++)
            {
                for (int j = 0; j < row_size; j++)
                {
                    tmp.matrix[i, j] = a.matrix[i, j] - b.matrix[i, j];
                }
            }

            return tmp;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            // number of elements in a column
            int col_size = a.matrix.GetLength(0);

            // number of elements in a row
            int row_size = a.matrix.GetLength(1);

            for (int i = 0; i < col_size; i++)
            {
                for (int j = 0; j < row_size; j++)
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
            // number of elements in a column
            int col_size = a.matrix.GetLength(0);

            // number of elements in a row
            int row_size = a.matrix.GetLength(1);

            for (int i = 0; i < col_size; i++)
            {
                for (int j = 0; j < row_size; j++)
                {
                    //compares values at matching coordinates 
                    if (a.matrix[i, j] == b.matrix[i, j])
                        return false;
                }
            }
            return true;
        }
    }
}
