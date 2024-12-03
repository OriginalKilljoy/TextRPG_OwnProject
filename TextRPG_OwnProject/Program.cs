/*TEXT RPG
Lag lage en karakter med klasse, equipment osv, hvor man kan gjøre oppdrag og tjene penger.
En liten fantasiverden som kommer til live med forklaring og hovedpersonens valg i forhold til hvor en skal reise,
hvilken oppdrag en takker ja til, og hvem en angriper.


[]Main character
[]Environment - Bulletin board, tavern, shops, NPCs
[]Quests - receive money, receive reputation
[]Villains
[]Backpack
*/

using TextRPG_OwnProject;



Console.WriteLine("Welcome welcome traveller, to the world of Ceesharpia!\n" +
                  "Something tells me you're in the mood for an adventure, yes?\n" +
                  "Before we begin, what is your name?");
var player = new Player(Console.ReadLine());
Console.WriteLine($"\nHello {player.Name}! Are you ready to begin your adventure?");
Console.WriteLine("[1]Yes!\n[2]No...");
var letsBegin = Console.ReadLine();
