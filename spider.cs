using System;
using System.Collections.Generic;

namespace Terminal_RPG_Encounter
{
    public class Spider : Enemy {
        public Spider(string creature = "spider") : base (creature){
            name = creature;
            dexterity = 6;
            health = 75;
        }
        public void poisonSting(Human ally)
        {
            Random rand = new Random();
            if(ally == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                ally.health -= rand.Next(dexterity*4, dexterity*8);
            }
        }
    }
}