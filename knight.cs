using System;
using System.Collections.Generic;

namespace Terminal_RPG_Encounter
{
    public class Knight : Human {
        public Knight(string person = "Knight") : base (person){
            name = person;
            strength = 6;
            health = 200;
        }
        public void headbutt(Enemy creature)
        {
            if(creature == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                attack(creature);
                creature.intelligence -= 1;
            }
        }
        public void hamstring(Enemy creature)
        {
            if(creature == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                attack(creature);
                creature.dexterity -= 1;
            }
        }
    }
}