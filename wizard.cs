using System;
using System.Collections.Generic;

namespace Terminal_RPG_Encounter
{
    public class Wizard : Human {
        public Wizard(string person = "wizard") : base (person){
            name = person;
            intelligence = 6;
            health = 50;
        }
        public void heal()
        {
            Console.WriteLine("Healing");
            health += intelligence * 10;
        }
        public void fireball(Enemy creature)
        {
            Random rand = new Random();
            if(creature == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                creature.health -= rand.Next(intelligence * 1, intelligence * 4);
            }
        }
    }
}