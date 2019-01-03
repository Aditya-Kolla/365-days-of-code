using System;
using System.IO;
using System.Linq;
using System.Collections;
namespace Day2{
    class Q3{
        static void Main(string[] args)
        {
            System.Console.ReadLine();
            var remaining = Console.ReadLine().Split(new char[]{' '}).Select((k) => Int32.Parse(k)).OrderBy(k => k).ToArray();
            var stolen = 0;
            for(int i = 0; i < remaining.Length - 1; i++){
                if( remaining[i + 1] - remaining[i] > 1)
                    stolen += remaining[i + 1] -  remaining[i] - 1;
            }
            System.Console.WriteLine(stolen);
        }
    }
}