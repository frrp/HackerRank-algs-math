using System;
using System.Collections.Generic;
using System.IO;

class Solution 
{
    static void Main(String[] args) 
    {
        string[] input = Console.ReadLine().Split();
        int M = Convert.ToInt32(input[0]);
        int N = Convert.ToInt32(input[1]);
        double[][] Y = new double[N][];
        double[][] X = new double[N][];
        for (int z = 0; z < N; z++)
            {
            X[z] = new double[M+1];
            X[z][0] = 1;
            input = Console.ReadLine().Split();
            for (int w = 1; w < M+1; w++)
                X[z][w] = Convert.ToDouble(input[w]);
            Y[z] = new double[1];
            Y[z][0] = Convert.ToDouble(input[M]);
            }
        int Q = Int32.Parse(Console.ReadLine());
        double[][] F = new double[Q][];
        
        for (int z = 0; z < Q; z++)
            {
                F[z] = new double[M+1];
                F[z][0] = 1;
                input = Console.ReadLine().Split();
                for (int w = 1; w < M+1; w++)
                    F[z][w] = Convert.ToDouble(input[w-1]);
            }
        double[][] XT = Transpose(X);
        double[][] INV = InvertMatrix(MatrixMultiply(XT,X)); //matrix of size (M+1)*(M+1)
        double[][] XY = MatrixMultiply(XT,Y);
        double[][] B = MatrixMultiply(INV,XY);
        double[][] FMisc = new double[1][];
            
        for (int i = 0; i < Q; i++)
            {
                FMisc[1] = F[i];
                Console.WriteLine(MatrixMultiply(FMisc,B));
            }
    }

    
    public static double[][] Transpose(double[][] A)
    {
        int m = A[0].Length;
        int n = A.Length;
        double[][] T = new double[m][];
        for(int i=0;i<n;i++)  
          {  
          for(int j=0;j<m;j++)
              {
              T[j] = new double[n];
              T[j][i]=A[i][j];  
              }
          }
        return T;
    }
    
    
    public static double[][] MatrixMultiply(double[][] A, double[][] B)
    {
        double[][] C = new double[A.Length][];
        for (int i = 0; i < A.GetLength(0); i++)
            C[i] = new double[B[0].Length];

        if (A[0].Length != B.Length)
            throw new Exception("Wrong Dimensions");
        else
        {
           for (int i = 0; i <= A.Length - 1; i++)
            {
                for (int j = 0; j <= B[0].Length - 1; j++)
                {
                    C[i][j] = 0;
                    for (int k = 0; k <= A[0].Length - 1; k++)
                        C[i][j] = C[i][j] + A[i][k] * B[k][j];
                }
            }
        }
        return C;
    }
    
    /*
    * Matrix inversion by LUP decomposition.
    */
    public static double[][] InvertMatrix(double[][] A)
    {
        int n = A.Length;
        //e will represent each column in the identity matrix
        double[] e;
        //x will hold the inverse matrix to be returned
        double[][] x = new double[n][];
        for (int i = 0; i < n; i++)
        {
            x[i] = new double[A[i].Length];
        }
        /*
        * solve will contain the vector solution for the LUP decomposition as we solve
        * for each vector of x.  We will combine the solutions into the double[][] array x.
        * */
        double[] solve;

        //Get the LU matrix and P matrix (as an array)
        Tuple<double[][], int[]> results = LUPDecomposition(A);

        double[][] LU = results.Item1;
        int[] P = results.Item2;

        //Solve AX = e for each column ei of the identity matrix using LUP decomposition
        for (int i = 0; i < n; i++)
        {
            e = new double[A[i].Length];
            e[i] = 1;
            solve = LUPSolve(LU, P, e);
            for (int j = 0; j < solve.Length; j++)
            {
                x[j][i] = solve[j];
            }
        }
        return x;
    }
    
    
    /*
    * Perform LUP decomposition on a matrix A.
    * Return L and U as a single matrix(double[][]) and P as an array of ints.
    * We implement the code to compute LU "in place" in the matrix A.
    * In order to make some of the calculations more straight forward and to 
    * match Cormen's et al. pseudocode the matrix A should have its first row and first columns
    * to be all 0.
    * */
    public static Tuple<double[][], int[]> LUPDecomposition(double[][] A)
    {
        int n = A.Length-1;
        /*
        * pi represents the permutation matrix.  We implement it as an array
        * whose value indicates which column the 1 would appear.  We use it to avoid 
        * dividing by zero or small numbers.
        * */
        int[] pi = new int[n+1];
        double p = 0;
        int kp = 0;
        int pik = 0;
        int pikp = 0;
        double aki = 0;
        double akpi = 0;

        //Initialize the permutation matrix, will be the identity matrix
        for (int j = 0; j <= n; j++)
            pi[j] = j;

        for (int k = 0; k <= n; k++)
        {
            /*
            * In finding the permutation matrix p that avoids dividing by zero
            * we take a slightly different approach.  For numerical stability
            * We find the element with the largest 
            * absolute value of those in the current first column (column k).  If all elements in
            * the current first column are zero then the matrix is singluar and throw an
            * error.
            * */
            p = 0;
            for (int i = k; i <= n; i++)
            {
                if (Math.Abs(A[i][k]) > p)
                {
                    p = Math.Abs(A[i][k]);
                    kp = i;
                }
            }
            if (p == 0)
                throw new Exception("singular matrix");
            /*
            * These lines update the pivot array (which represents the pivot matrix)
            * by exchanging pi[k] and pi[kp].
            * */
            pik = pi[k];
            pikp = pi[kp];
            pi[k] = pikp;
            pi[kp] = pik;

            //Exchange rows k and kpi as determined by the pivot
            for (int i = 0; i <= n; i++)
            {
                aki = A[k][i];
                akpi = A[kp][i];
                A[k][i] = akpi;
                A[kp][i] = aki;
            }

            //Compute the Schur complement
            for (int i = k+1; i <= n; i++)
            {
                A[i][k] = A[i][k] / A[k][k];
                for (int j = k+1; j <= n; j++)
                    A[i][j] = A[i][j] - (A[i][k] * A[k][j]); 
            }
        }
        return Tuple.Create(A,pi);
    }
    
    
    /*
    * Given L,U,P and b solve for x.
    * Input the L and U matrices as a single matrix LU.
    * Return the solution as a double[].
    * LU will be a n+1xm+1 matrix where the first row and columns are zero.
    * This is for ease of computation and consistency with Cormen et al.
    * pseudocode.
    * The pi array represents the permutation matrix.
    * */
    public static double[] LUPSolve(double[][] LU, int[] pi, double[] b)
    {
        int n = LU.Length-1;
        double[] x = new double[n+1];
        double[] y = new double[n+1];
        double suml = 0;
        double sumu = 0;
        double lij = 0;
        //Solve for y using formward substitution
        for (int i = 0; i <= n; i++)
        {
            suml = 0;
            for (int j = 0; j <= i - 1; j++)
            {
                /*
                * Since we've taken L and U as a singular matrix as an input
                * the value for L at index i and j will be 1 when i equals j, not LU[i][j], since
                * the diagonal values are all 1 for L.
                * */
                if (i == j)
                    lij = 1;
                else
                    lij = LU[i][j];
                suml = suml + (lij * y[j]);
            }
            y[i] = b[pi[i]] - suml;
        }
        //Solve for x by using back substitution
        for (int i = n; i >= 0; i--)
        {
            sumu = 0;
            for (int j = i + 1; j <= n; j++)
                sumu = sumu + (LU[i][j] * x[j]);
            x[i] = (y[i] - sumu) / LU[i][i];
        }
        return x;
    }
}