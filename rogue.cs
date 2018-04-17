using System;
using System.Collections.Generic;

namespace Terminal_RPG_Encounter
{
    public class Rogue : Human {
        public Rogue(string person = "Rogue") : base (person){
            name = person;
            dexterity = 6;
        }
        public void deathblow(Enemy creature)
        {
            if(creature == null || creature.health > 49)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                creature.health = 0;
            }
        }
        public void get_away()
        {
            Console.WriteLine("Escaping");
            health -= 15;
        }
    }
}