using System;
namespace Day3
{
    public class Question1{

        static void Main(string[] args)
        {
            int t = Int32.Parse (Console.ReadLine ());
            while (t-- > 0) {
                int n = Int32.Parse (Console.ReadLine ());
                var attacks = Console.ReadLine ().Split (new char[] { ' ' }).Select ((k) => Int32.Parse (k)).ToArray ();
                var defenses = Console.ReadLine ().Split (new char[] { ' ' }).Select ((k) => Int32.Parse (k)).ToArray ();
                int shield = -1, attack;
                //First soldier
                attack = attacks[1] + attacks[n - 1];
                if (defenses[0] > attack)
                    shield = defenses[0];
                //Remaining soldiers
                for (int i = 1; i < n - 1; i++) {
                    if (shield >= defenses[i])
                        continue;
                    attack = attacks[i + 1] + attacks[i - 1];
                    if (defenses[i] > attack)
                        shield = defenses[i];
                }
                //Last soldier
                attack = attacks[0] + attacks[n - 2];
                if (defenses[n - 1] > attack && defenses[n - 1] > shield)
                    shield = defenses[n - 1];
                Console.WriteLine (shield);
			}
    }
}
