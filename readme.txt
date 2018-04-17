(Optional) Terminal RPG Encounter
Using what we learned in the last assignment we could easily continue building these out into an entire Game. All we need to make this a reality is some simple game logic such as turns and a winning condition, an Enemy class with a few monster classes that inherit from it, and the ability to receive terminal input.

You can easily get input from the console using the following line:

string InputLine = Console.ReadLine();
The console will prompt and wait for input which will then be saved to the variable InputLine as a string.

 Create the Zombie and Spider class from the Enemy Class and build objects for them and the heros
 Create a basic encounter between an Ally party of a Ninja, Samurai, and Wizard vs two Zombies and a Spider
 Players use the text input to determine which attack to use
 If all enemies' or all players' health are brought to 0hp then the encounter is over and you should announce the winner
 Build a turn system! Modulus and an array may help a lot here