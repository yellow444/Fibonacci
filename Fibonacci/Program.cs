using System;
using System.IO;
using System.Numerics;
namespace Fibonacci
{
    internal class Program
    {
        private static void Main(string [] args)
        {

            Console.WriteLine (Fibonacci.Fib (2000000));
            Console.ReadKey ( );

        }
    }
    public class Fibonacci
    {
        public static BigInteger Fib(int n)
        {
            StreamWriter sw = new StreamWriter (Console.OpenStandardOutput ( ))
            {
                AutoFlush = true
            };
            Console.SetOut (sw);
            Console.Error.WriteLine (n);
            Console.Out.WriteLine (n);
            BigInteger x, ta, tc, tb;
            BigInteger a = 1;
            BigInteger b = 1;
            BigInteger c = 1;
            BigInteger rc = 0;
            BigInteger d = 0;
            BigInteger rd = 1;
            x = n;
            if ( n < 0 )
            {
                n = Math.Abs (n);
                while ( n > 0 )
                {
                    if ( (n + 1) % 2 == 0 )  
                    {
                        tc = rc;
                        rc = rc * a + rd * c;
                        rd = tc * b + rd * d;
                    }
                    ta = a; tb = b; tc = c;
                    a = a * a + b * c;
                    b = ta * b + b * d;
                    c = c * ta + d * c;
                    d = tc * tb + d * d;
                    n >>= 1;  
                }
                if ( (x + 1) % 2 == 0 )
                {
                    x = rc;
                }
                else
                {
                    x = BigInteger.Negate (rc);
                }
                return x;
            }
            if ( n > 0 )
            {
                while ( n > 0 )
                {
                    if ( (n + 1) % 2 == 0 )    
                    {
                        tc = rc;
                        rc = rc * a + rd * c;
                        rd = tc * b + rd * d;
                    }
                    ta = a; tb = b; tc = c;
                    a = a * a + b * c;
                    b = ta * b + b * d;
                    c = c * ta + d * c;
                    d = tc * tb + d * d;
                    n >>= 1;  
                }
                x = rc;
                return x;
            }
            return 0;
        }
        public static BigInteger Fib2(int n)
        {
            if ( n < 0 )
            {
                n = Math.Abs (n);
                int x;
                double y, t1, t2;
                y = Math.Sqrt (5);
                t1 = Math.Pow ((1 + y) / 2, n);
                t2 = Math.Pow ((1 - y) / 2, n);
                x = ( int )(((t1 - t2) / y) * Math.Pow (-1, n + 1));
                return x;
            }
            if ( n > 0 )
            {
                int x;
                double y, t1, t2;
                y = Math.Sqrt (5);
                t1 = Math.Pow ((1 + y) / 2, n);
                t2 = Math.Pow ((1 - y) / 2, n);
                x = ( int )((t1 - t2) / y);
                return x;
            }
            return 0;
        }
        public static BigInteger Fib1(int n)
        {
            StreamWriter sw = new StreamWriter (Console.OpenStandardOutput ( ))
            {
                AutoFlush = true
            };
            Console.SetOut (sw);
            Console.Error.WriteLine ( );
            Console.Out.WriteLine ( );
            if ( n == 0 ) { return 0; }
            if ( n == 1 ) { return 1; }
            if ( n == -1 ) { return 1; }
            if ( n == -2 ) { return -1; }
            BigInteger [] f = new BigInteger [3];
            if ( n > 0 )
            {
                f [1] = 1;
                for ( int i = 2; i <= n; i++ )
                {
                    f [i % 3] = f [(i + 1) % 3] + f [(i + 2) % 3];
                }
                return f [n % 3];
            }
            f [1] = 1;
            for ( int i = -2; i >= n; i-- )
            {
                f [-i % 3] = f [(-i + 1) % 3] + f [(-i + 2) % 3];
            }
            return f [n % 3];
        }
    }
}
