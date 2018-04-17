using System;
using System.Collections.Generic;

namespace Terminal_RPG_Encounter
{
    //Need to make sure that you can pick multiples of the same class for your team
    class CharacterSelect{
        public static void character_select(){
            int playerSelect = 0;
            int choices = 3 - playerSelect;
            while (playerSelect < 3){
                Console.WriteLine("Choose a character to join your team. You have {0} more allies to choose!", choices);
                Console.WriteLine("Type 1 for Human");
                Console.WriteLine("Humans are weak and have nothing special about them. Only an experienced dungeon master would pick a human as a ally");
                System.Console.WriteLine();
                Console.WriteLine("Type 2 for Wizard");
                Console.WriteLine("Wizards have low health but make up for that in intellect. Wizard's have learned how to heal themselves and wizard's fireball can incinerate an enemy!");
                System.Console.WriteLine();
                Console.WriteLine("Type 3 for Rogue");
                Console.WriteLine("Rogue's are masters of stealth and assassination. They can finish off enemies or help the team escape from a battle!");
                System.Console.WriteLine();
                Console.WriteLine("Type 4 for Knight");
                Console.WriteLine("Knights are stronger and have more health than other allies. A knight's headbutt and sheildbash abilities reduce base stats in addition to damaging an enemy!");
                System.Console.WriteLine();
                string InputLine = Console.ReadLine();
                switch (InputLine) {
                    case "1":
                        Console.WriteLine("What is this human's name?");
                        string nameInput = Console.ReadLine();
                        Human humanPlayer = new Human(nameInput);
                        playerSelect += 1;
                        humanPlayer.showStats();
                        System.Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("What is this Wizard's name?");
                        string wizardNameInput = Console.ReadLine();
                        Wizard wizardPlayer = new Wizard(wizardNameInput);
                        playerSelect += 1;
                        wizardPlayer.showStats();
                        System.Console.WriteLine();
                        break;
                    case "3":
                        Console.WriteLine("What is this Rogue's name?");
                        string rogueNameInput = Console.ReadLine();
                        Rogue rougePlayer = new Rogue(rogueNameInput);
                        playerSelect += 1;
                        rougePlayer.showStats();
                        System.Console.WriteLine();
                        break;
                    case "4":
                        Console.WriteLine("What is this Knight's name?");
                        string knightNameInput = Console.ReadLine();
                        Knight knightPlayer = new Knight(knightNameInput);
                        playerSelect += 1;
                        knightPlayer.showStats();
                        System.Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Please select a hero");
                        System.Console.WriteLine();
                        break;
                }
            }
        }
    }
}