using System;
using System.Collections.Generic;

namespace Day31
{
    public class Question1{

        static Dictionary<char, bool> Cleanup(Dictionary<char, bool> ingredients){
            var specialIngredients = new Dictionary<char, bool>();
            foreach (var ingredient in ingredients)
            {
                if(ingredient.Value)
                    specialIngredients.Add(ingredient.Key, false);
            }
            return specialIngredients;
        }

        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());
            while(t-- > 0){
                int n = Int32.Parse(Console.ReadLine());
                var ingredients =  new Dictionary<char, bool>();
                var dish = Console.ReadLine().ToCharArray();
                foreach(var d in dish){
                    if(!ingredients.ContainsKey(d))
                        ingredients.Add(d, false);
                }
                for(int i = 1; i < n; i++){
                    dish = Console.ReadLine().ToCharArray();
                    foreach(var d in dish){
                        if(!ingredients.ContainsKey(d))
                            continue;
                        else
                            ingredients[d] = true;
                    }
                    ingredients = Cleanup(ingredients);
                }
                Console.WriteLine(ingredients.Count);
            }
        }
    }
}
