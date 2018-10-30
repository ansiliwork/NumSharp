using System;
using System.Linq;

namespace NumSharp
{
    public partial class Matrix<TData>
    {
        public TData[,] Data {get;set;}
        public Matrix()
        {

        }
        public Matrix(string matrixString)
        {
            string[][] splitted = null;

            if (matrixString.Contains(","))
            {
                splitted = matrixString.Split(';')
                                              .Select(x => x.Split(',') )
                                              .ToArray();
            }
            else 
            {
                splitted = matrixString.Split(';')
                                              .Select(x => x.Split(' ') )
                                              .ToArray();
            }
            
            int dim0 = splitted.Length;
            int dim1 = splitted[0].Length;

            Data = new TData[dim0,dim1];

            var dataType = typeof(TData);

            switch (dataType.Name)
            {
                case ("Double"): this.StringToDoubleMatrix(splitted); break;
                case ("Float"): ; break;
                case ("Complex"): this.StringToComplexMatrix(splitted); break;
            }
            
        }
        /// <summary>
        /// Convert a string to Double[,] and store
        /// in Data field of Matrix object
        /// </summary>
        /// <param name="matrix"></param>
        protected void StringToDoubleMatrix(string[][] matrix)
        {
            dynamic matrixData = this.Data;

            for (int idx = 0; idx< matrix.Length;idx++)
            {
                for (int jdx = 0; jdx < matrix[0].Length;jdx++)
                {
                    matrixData[idx,jdx] = Double.Parse(matrix[idx][jdx]);
                }
            }
        }
        protected void StringToComplexMatrix(string[][] matrix)
        {
            
        }

        public override string ToString()
        {
            string returnValue = "matrix([[";

            int dim0 = Data.GetLength(0);
            int dim1 = Data.GetLength(1);

            for (int idx = 0; idx < (dim0-1);idx++)
            {
                for (int jdx = 0;jdx < (dim1-1);jdx++)
                {
                    returnValue += (Data[idx,jdx] + ", ");
                }
                returnValue += (Data[idx,dim1-1] + "],   \n        [");
            }
            for (int jdx = 0; jdx < (dim1-1);jdx++)
            {
                returnValue += (Data[dim0-1,jdx] + ", ");
            }
            returnValue += (Data[dim0-1,dim1-1] + "]])");

            return returnValue;    
        }
    }
}