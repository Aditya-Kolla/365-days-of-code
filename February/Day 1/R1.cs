using System;
using System.Collections.Generic;

namespace Day1
{
    public class Question1{

        static long GCD(long a, long b){
            if(a == 0)
                return b;
            return GCD(b % a, a);
        }

        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());
            while(t-- > 0){
                var inputs = Console.ReadLine().Split(new char[]{' '});
                long n = long.Parse(inputs[0]), a = long.Parse(inputs[1]), b = long.Parse(inputs[2]), k = long.Parse(inputs[3]);
                long gcd = GCD(a, b);
                long lcm = (a/gcd)*b;
                long divisbleByA = n / a, divisbleByB = n / b, divisbleByBoth = n / lcm;
                if(divisbleByA + divisbleByB - (divisbleByBoth * 2) >= k)
                    Console.WriteLine("Win");
                else
                    Console.WriteLine("Lose");
            }
    }
}
