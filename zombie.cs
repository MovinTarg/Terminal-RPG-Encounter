using System;
using System.Collections.Generic;

namespace Terminal_RPG_Encounter
{
    public class Zombie : Enemy {
        public Zombie(string creature = "zombie") : base (creature){
            name = creature;
            health = 150;
        }
        public void eatFlesh(Human ally)
        {
            Random rand = new Random();
            if(ally == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                int temp = rand.Next(intelligence*5, intelligence*7);
                ally.health -= temp;
                health += temp;
            }
        }
    }
}