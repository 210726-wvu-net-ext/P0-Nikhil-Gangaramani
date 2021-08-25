namespace ProgrammingBasics
{
    public class Factorial
    {
        internal static int CalculateFactorial(int n)
        {
            #region Factorial
                
            if(n==0){
                return 1;
            }
            int factorial = 1;
            for (int i = n; i >=1; i--)
            {
                factorial *= i;
            }
            /* int i = n;
            while(i >= 1)
            {
                factorial *= i;
                i--;
            } */
            return factorial;
            #endregion
        }

        internal static int CalculateFactorial_Recursive(int n)
        {
            #region Facorial_Recursive
                
           if (n==0)
                return 1;
            return n *= CalculateFactorial_Recursive(n-1);  // 4,3,2,1,0

             #endregion
        }
    }
}