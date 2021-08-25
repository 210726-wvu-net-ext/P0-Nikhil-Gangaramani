using System;
using System.Collections.Generic;

    


namespace csharpweek3
{   
    /// <summary>
    /// Program class is the main entry point of this program
    /// </summary>
    class Program
    {
        public static void Main(string[] args)
        {
            //XMLDocumentation.add(2, 3);

            //TypeConversion.Boxing();

            /* int inParam = 20;
            int refParam = 30;
            int outParam = 0;
            Console.WriteLine(outParam);
            Console.WriteLine(refParam);
            TypeConversion.ParamMod(out outParam, inParam, ref refParam) ;
            Console.WriteLine(outParam);
            Console.WriteLine(refParam);

            */

            // TypeChecking.TypeCheck();
            // List<int> list = GenericCollection.List();
            // foreach(int n in list)
            // {
            //     Console.WriteLine(n);
            // }

            // Console.WriteLine(list.Count);
            // // Covariant Child in place of parent
            // List<int> intList = new List<int>();
            // List<Object> objectList = intList; //List<int>

            // // Contravariant : parent in place of child
            // Action<FirstGen> FirstGenAction = (target) => { Console.WriteLine(target.GetType().Name); };
            // Action<SecondGen> SecondGenAction = FirstGenAction; //Action<FirstGen>
            // SecondGenAction(new SecondGen());

           

            try
            {
                
                 ExceptionHandling.ExceptionExample();
            }
            catch(IndexOutOfRangeException ex)
            {
                 Console.WriteLine("we caught it here!! {0}", ex);
                
            }
            catch(Exception ex)
            {
                Console.WriteLine("This cathes all other Exceptions {0}", ex);
            }

            finally
            {
                Console.WriteLine("This block is executed regardless of exception");
            }

           
                
            

        }
      
    }

    /// <summary>
    ///  XML documentation demo class
    /// </summary>


    class XMLDocumentation
    {
        /// <summary>
        /// It adds numbers
        /// </summary>
        /// <param name="n">an integer to add</param>
        /// <param name="m">another int to add</param>
        /// <returns>an integer n + m</returns>
        public static int add(int n, int m)
        {
            return n + m;
        }

    }

    class TypeConversion
    {
            public static void Boxing()
            {
                int i = 5;
                //boxing this integer
                object o = i;
                object p = i;

               // Console.Write(ReferenceEquals(o, p));

               // Unboxing 
               int n = (int)o;
               Console.WriteLine($"Unboxing : {n}");

            }

            /// <summary>
            /// Pass by reference example
            /// </summary>
            /// <param name="outParam">out integer param, must have value before function exists</param>
            /// <param name="inParam">in integer param, cannot be changed inside the method</param>
            /// <param name="refParam">ref integer param, must be initialized before calltime</param>
            public static void ParamMod(out int outParam, in int inParam, ref int refParam)
            {
                outParam = 100;

                refParam = outParam * refParam;

                // inParam = 0; // its not goin to work

            }

            public static void Foo(int var)
            {

            }

    }

    class TypeChecking
    {
        public static void TypeCheck()
        {
            // typeof, GetType, Is, and As
            // Console.WriteLine(typeof(int));
            /* int m = 100;
             typeof(m); */ // will give an error
            //m.GetType();

            //int n = 10;
            // Program runs, stuff happens to n
            //Console.WriteLine($"N GetType: {n.GetType()} ");

            //Console.WriteLine($"Is an integer? {n.GetType() == typeof(int)}");

            //SecondGen two = new SecondGen();
            //Console.WriteLine($"Is two second gen {two is SecondGen}");
            //Console.WriteLine($"Is two first gen {two is FirstGen}");
            //Console.WriteLine($"Is two really first gen {two.GetType() == typeof(FirstGen)}");

            // as operator

            // int m = 100;
            
            // Object o = m as Object;
            // object o = (object)m;
            //object o = new object(m);

            //Console.WriteLine(o.GetType());

            // what is happening under the hood with as operator
            // if(m is object)
            // {
            //     o = (object)m;
            // }
            // else
            // {
            //     o = null;
            // }

        }

    }
    
    class FirstGen
    {

    }

    class SecondGen : FirstGen
    {

    }

    class GenericCollection
    {
        public static List<int> List()
        {

            // array of integers
        int[] arr = new int[5]{1, 2, 3, 4, 5};
        List<int> intList = new List<int>();
        // List<int> anotherList = new List<int>(){1, 2, 3, 4, 5};
         intList.Add(10);
        // intList.AddRange(anotherList);
        return intList;

        }
        

    }

    class ExceptionHandling
    {
        public static void ExceptionExample()
        {
            int[] arr = new int[4];

            try
            {
                // Risky Code. Gonna throw an exception
                Console.WriteLine(arr[10]);
            }
            catch(IndexOutOfRangeException ex)
            {
                // Console.WriteLine("handled exception {0}", ex);
                // throw;
                throw new CustomException("we're throwing a custom exception");
                //throw new InvalidCastException("You done something wrong");
            }
            finally
            {
                Console.WriteLine("This block is executed regardless of exception");
            }
            

        }

    }

    
    [System.Serializable]
    public class CustomException : Exception
    {
        public CustomException() { }
        public CustomException(string message) : base(message) { }
        public CustomException(string message, System.Exception inner) : base(message, inner) { }
        protected CustomException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

