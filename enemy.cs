using System;
using System.Collections.Generic;

namespace Terminal_RPG_Encounter
{
    public class Enemy
    {
        public string name;

        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Enemy(string creature)
        {
            name = creature;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Enemy(string creature, int str, int intel, int dex, int hp)
        {
            name = creature;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(Human ally)
        {
            if(ally == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                ally.health -= strength * 5;
            }
        }
    }
}