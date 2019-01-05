using System;
using System.IO;
using System.Linq;

namespace Day4
{
    class Q1
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
            var sequence = Console.ReadLine().Split(new char[]{' '}).Select((s) => Int32.Parse(s)).ToArray();
            var max = 1;
            int temp = 1;
            for(int i = 0; i < sequence.Length - 1; i++){
                if(sequence[i + 1] >= sequence[i])
                    temp++;
                else{
                    if(max < temp)
                        max = temp;
                    temp = 1;
                }
            }
            if(max < temp)
                max = temp;
            System.Console.WriteLine(max);
        }
    }
}