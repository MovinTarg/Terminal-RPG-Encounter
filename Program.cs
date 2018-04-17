using System;

namespace Terminal_RPG_Encounter
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine();
            System.Console.WriteLine("_____Welcome to Dungeon Adventure!_____");
            System.Console.WriteLine();
            System.Console.WriteLine("Press any key to start your quest!");
            System.Console.ReadKey();
            System.Console.WriteLine();
            CharacterSelect.character_select();
        }
    }
}
