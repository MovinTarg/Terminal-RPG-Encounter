using System;
using System.Collections.Generic;

namespace Terminal_RPG_Encounter
{
    public class Skeleton : Enemy {
        public Skeleton(string creature = "Skeleton") : base (creature){
            name = creature;
            strength = 5;
            health = 175;
        }
        public void headbutt(Human ally)
        {
            if(ally == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                attack(ally);
                ally.intelligence -= 1;
            }
        }
    }
}