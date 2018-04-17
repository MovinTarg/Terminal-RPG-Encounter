using System;
using System.Collections.Generic;

namespace Terminal_RPG_Encounter
{
    public class Human
    {
        public string name;

        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string person = "person")
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(Enemy creature)
        {
            if(creature == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                creature.health -= strength * 5;
            }
        }
        public void showStats()
        {
            Console.WriteLine(strength);
            Console.WriteLine(intelligence);
            Console.WriteLine(dexterity);
            Console.WriteLine(health);
        }
    }
}