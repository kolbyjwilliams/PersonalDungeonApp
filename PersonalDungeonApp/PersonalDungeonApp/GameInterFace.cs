using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace PersonalDungeonApp
{
    class GameInterFace
    {
        static void Main(string[] args)
        {
            Console.Title = "The Land Down Under";
            Console.WriteLine("Your Jorney Begins Now.");
            int score = 0;
            //TODO create player
            Weapons w1 = new Weapons(5, 15, "Dual-Handed Axe", 40, 25);
            Weapons w2 = new Weapons(2, 10, "Long Bow", 25, 35);
            Console.WriteLine("Pick your weapon:\n" + 
                "1.)Long Bow\n" +
                "2.)Dual-Handed Axe");
            string UserWeapon = Console.ReadLine().ToUpper();
            Console.Clear();
            switch (UserWeapon)
            {
                case "DUAL-HANDED AXE":
                case "DUAL HANDED AXE":
                case "2":
                    UserWeapon = Convert.ToString(w1);
                    break;
                case "LONG BOW":
                case "BOW":
                case "1":
                    UserWeapon = Convert.ToString(w2);
                    break;

                default:
                    Console.WriteLine("Sorry that is not a valid input try again");
                    break;
            }
            Player p1 = new Player("Kolby", Race.WoodElf , "A strong, attractive, and young warrior", , 10, 10, 70);

            //Rooms and monsters
            bool exit = false;
            do
            {
                Console.WriteLine(Getroom());
                bool menu = false;
                do
                {
                    #region Menu Loop
                    Console.WriteLine("Pick an action:\n" + 
                        "Attack\n" + 
                        "Flee\n" + 
                        "Player Stats\n" + 
                        "Monster Stats\n" + 
                        "Exit");
                    string UserAction = Console.ReadLine().ToUpper();
                    Console.Clear();

                    switch (UserAction)
                    {
                        case "ATTACK":
                        case "A":
                            Console.WriteLine("You attacked the monster");
                            break;
                        case "FLEE":
                        case "F":
                            //Console.WriteLine($"{monsterName} Strikes a hit but you succesfully flee!");
                            break;
                        case "P":
                        case "PLAYER":
                        case "PLAYER STATS":

                            break;
                        case "M":
                        case "MONSTER":
                        case "MONSTER STATS":

                            break;
                        case "EXIT":
                        case "E":
                        case "X":
                            Console.WriteLine("Thanks for playing... Coward.");
                            menu = true;
                            exit = true;
                            break;
                        default:
                            break;
                    }
                    #endregion

                } while (!menu && !exit);

            } while (!exit);
        }//end main
        private static string Getroom()
        {
            string[] rooms =
            {
                "This short hall leads to another door. On either side of the hall, niches are set into the wall within which stand clay urns. One of the urns has been shattered, and its contents have spilled onto its shelf and the floor. Amid the ash it held, you see blackened chunks of something that might be bone.",

                "A pit yawns open before you just on the other side of the door's threshold. The entire floor of the room has fallen into a second room beneath it. Across the way you can spy a door in the wall now 15 feet off the rubble-strewn floor, and near the center of the room stands a thick column of mortared stone that appears to hold the spiral staircase that leads down to what was the lower level.",

                "A skeleton dressed in moth-eaten garb lies before a large open chest in the rear of this chamber. The chest is empty, but you note two needles projecting from the now-open lock. Dust coats something sticky on the needles' points.",

                "Neither light nor darkvision can penetrate the gloom in this chamber. An unnatural shade fills it, and the room's farthest reaches are barely visible. Near the room's center, you can just barely perceive a lump about the size of a human lying on the floor. (It might be a dead body, a pile of rags, or a sleeping monster that can take advantage of the room's darkness.)",

                "This chamber was clearly smaller at one time, but something knocked down the wall that separated it from an adjacent room. Looking into that space, you see signs of another wall knocked over. It doesn't appear that anyone made an effort to clean up the rubble, but some paths through see more usage than others.",

                "Several white marble busts that rest on white pillars dominate this room. Most appear to be male or female humans of middle age, but one clearly bears small horns projecting from its forehead and another is spread across the floor in a thousand pieces, leaving one pillar empty.",

                "This narrow room at first appears to be a dead-end corridor, but then you note several metal plates on the walls set at about eye height. Looking more closely, you see that one of these plates is slid aside to reveal a peephole.",

                " The burble of water reaches your ears after you open the door to this room. You see the source of the noise in the far wall: a large fountain artfully carved to look like a seashell with the figure of a seacat spewing clear water into its basin.",

                "This room is hung with hundreds of dusty tapestries. All show signs of wear: moth holes, scorch marks, dark stains, and the damage of years of neglect. They hang on all the walls and hang from the ceiling to brush against the floor, blocking your view of the rest of the room."
            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length + 1);
            string room = "-=-=-=-=NEW ROOM=-=-=-=-\n" + rooms[indexNbr] + "\n";
            return room;
        }//end get room
    }//end class
}//end namespace
