using System;
using System.IO;
using System.Linq;
using System.Collections;
namespace Day2{
    class Q3{
        static void Main(string[] args)
        {
            int n = Int32.Parse(System.Console.ReadLine())/2;
            var cards = System.Console.ReadLine().Split(new char[]{' '}).Select((c) => Int32.Parse(c)).ToArray();
            int req = cards.Sum()/n;
            int j = 0, k = 0;
            for(int i = 0; i < n; i++){
                while(cards[j++] == -69);
                var card = cards[--j];
                cards[j] = -69;
                for(k = j; k < cards.Length; k++)
                    if(cards[k] == req - card)
                        break;
                cards[k] = -69;
                j++;
                System.Console.WriteLine((j) + " " + (k + 1));
            }
        }
    }
}