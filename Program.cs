using System;

namespace Wump_Wump
{
    public class Player
    {
        public static int arrows = 5;
        //private static bool canMove = true;
        public static bool dead = false;
        public static int playerRoom = 1;
        public static int batRepel = 1;
        public static bool haveTracker = true;
        public static int roomShot = 0;
    }

    public class Wumpus
    {
        public static int asleep = 1;
        public static int wRoom = 6;
        public static bool move = false;
        public static bool wDead = false;
    }

    // It's kinda dumb that these two are classes tbh 
    public class Bats
    {
        public static int bRoom1 = 12;
        public static int bRoom2 = 10;
    }

    public class Holes
    {
        public static int hRoom1 = 8;
        public static int hRoom2 = 3;
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] bat = new int[2] { 4, 18 };
            int[] holes = new int[2] { 8, 13 };*/

            string choice = "m";

            int trackerRoom = 0;

            Console.WriteLine("Let's go Wumpus hunting! You have 5 arrows to bring home the wumpus, if you run out or run into trouble...");
            Console.Write("Well, let's just hope that doesn't happen. I've given you a wumpus tracker and bat repellant to try and help you out. \nI'm dropping you into the cave, so do your best! ");
            Random awoken = new Random();
            Random change = new Random();
            Random bats = new Random();
            //TODO: Have game not accept invalid string; Have movement locked to adjacent sides of the dodecahedron;
            // Objective have player be able to move CLEAR

            bool winnerWinner = false;
            //bool justNo = false;

            while (Player.dead != true || Player.arrows >= 0)
            {
                if (winnerWinner)
                {
                    choice = "m";
                    if (choice == "m")
                    {
                        Console.WriteLine("With the wumpus dead, you can only move forward.");
                    }
                    else
                    {
                        Console.WriteLine(choice);
                    }
                    //choice stays "m" so after wumpus is dead you can no longer shoot.
                }
                else
                {
                    Console.WriteLine("Move (m) or shoot (s)?");
                    choice = Console.ReadLine();
                }
                

                if (Wumpus.wDead == false)
                {
                    Wumpus.asleep = (awoken.Next(0, 4));
                    if (Wumpus.asleep == 1)
                    {
                        int movement = change.Next(-1, 1);
                        Wumpus.wRoom += movement;
                    }
                }
                else
                {
                    Wumpus.asleep = 0;
                    Wumpus.wRoom = 0;
                }

                bool sleepyWumpus = false;

                if (Wumpus.asleep == 0)
                {
                    sleepyWumpus = false;
                }
                else
                {
                    sleepyWumpus = true;
                }

                //bool sleepyWumpus = Boolean.Parse(Wumpus.asleep);

                if (!Player.haveTracker)
                {
                    if (Wumpus.wRoom == trackerRoom)
                    {
                        Console.WriteLine("The tracker is beeping. Looks like the Wumpus just went into room " + trackerRoom + ".");
                    }
                }

                if (choice == "m")
                {
                    Console.Write("Where to?");
                    switch (Player.playerRoom)
                    {
                        case 1:
                            Console.WriteLine("You can move to room 2, 4, 5, 6, or 10.");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 2 | Player.playerRoom == 4 | Player.playerRoom == 5 | Player.playerRoom == 6 | Player.playerRoom == 10) 
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 2:
                            Console.WriteLine("You can move to room 1, 4, 7, 8 or 10");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 1 | Player.playerRoom == 4 | Player.playerRoom == 7 | Player.playerRoom == 8 | Player.playerRoom == 10)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 3:
                            Console.WriteLine("You can move to room 4, 6, 8, 11 or 12");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 4 | Player.playerRoom == 6 | Player.playerRoom == 8 | Player.playerRoom == 11 | Player.playerRoom == 12)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 4:
                            Console.WriteLine("You can move to room 1, 2, 3, 6 or 8");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 1 | Player.playerRoom == 2 | Player.playerRoom == 3 | Player.playerRoom == 6 | Player.playerRoom == 8)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 5:
                            Console.WriteLine("You can move to room 1, 6, 9, 10 or 11");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 1 | Player.playerRoom == 6 | Player.playerRoom == 9 | Player.playerRoom == 10 | Player.playerRoom == 11)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 6:
                            Console.WriteLine("You can move to room 1, 3, 4, 5, or 11");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 1 | Player.playerRoom == 3 | Player.playerRoom == 4 | Player.playerRoom == 5 | Player.playerRoom == 11)
                            {
                                break;
                            }
                            else 
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 7:
                            Console.WriteLine("You can move to room 2, 8, 9, 10, or 12");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 2 | Player.playerRoom == 8 | Player.playerRoom == 9 | Player.playerRoom == 10 | Player.playerRoom == 12)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 8:
                            Console.WriteLine("You can move to room 2, 3, 4, 7 or 12");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 2 | Player.playerRoom == 3 | Player.playerRoom == 4 | Player.playerRoom == 7 | Player.playerRoom == 12)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 9:
                            Console.WriteLine("You can move to room 5, 7, 10, 11 or 12");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 5 | Player.playerRoom == 7 | Player.playerRoom == 10 | Player.playerRoom == 11 | Player.playerRoom == 12)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 10:
                            Console.WriteLine("You can move to room 1, 2, 5, 7 or 9");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 1 | Player.playerRoom == 2 | Player.playerRoom == 5 | Player.playerRoom == 7 | Player.playerRoom == 9)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 11:
                            Console.WriteLine("You can move to room 3, 5, 6, 9 or 12");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 3 | Player.playerRoom == 5 | Player.playerRoom == 6 | Player.playerRoom == 9 | Player.playerRoom == 12)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        case 12:
                            Console.WriteLine("You can move to room 3, 7, 8, 9 or 11");
                            Player.playerRoom = Int32.Parse(Console.ReadLine());
                            if (Player.playerRoom == 3 | Player.playerRoom == 7 | Player.playerRoom == 8 | Player.playerRoom == 9 | Player.playerRoom == 11)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Choose a valid room");
                                //justNo = true;
                                break;
                            }
                        default:
                            if (Wumpus.wDead == true)
                            {

                            }
                            break;
                    }
                    
                    // Console.WriteLine("You can move " + (Player.playerRoom -2) + ".");
                    
                    switch (Player.playerRoom)
                    {
                        case 3:
                            Console.WriteLine("Oh no! You fell into a hole. Legends say you never stopped.");
                            Player.dead = true;
                            Console.WriteLine("Thank you for playing Hunt the Wumpus! Hope you enjoyed your adventure!");
                            Environment.Exit(0);
                            break;
                        case 8:
                            Console.WriteLine("Oh no! You fell into a hole. Legends say you never stopped.");
                            Player.dead = true;
                            Console.WriteLine("Thank you for playing Hunt the Wumpus! Hope you enjoyed your adventure!");
                            Environment.Exit(0);
                            break;
                        case 10:
                            if (Player.batRepel >= 1)
                            {
                                if (winnerWinner != true)
                                {
                                    Console.WriteLine("As you walk in, you cause such a ruckus that you disturb some bats sleeping on the ceiling.");
                                    Console.WriteLine("They don't look too bothered but you sprayed your bat repellant at them to be safe.");
                                }
                                else
                                {
                                    Console.WriteLine("These could the bats that take you to the treasure, but you still have your bat repellant if they're not");
                                }
                                
                            }
                            else
                            {
                                if (winnerWinner != true)
                                {
                                    //generates room bats take you to
                                    int batty = (bats.Next(1, 12));
                                    Console.WriteLine("These bats look different than the rest. While you're trying to figure out why, the bats whisked you away to a random room!");
                                    Console.WriteLine("You are now in room " + batty + ".");
                                }
                                else
                                {
                                    int batty = 13;
                                    Console.WriteLine("The bats took you room ..." + batty + "?! This wasn't on the map.");
                                    Console.WriteLine("It's a hidden treaure trove! You're gonna be rich!");
                                    break;
                                }
                                
                            }
                            break;
                        case 12:
                            Console.WriteLine("As you walk in, you cause such a ruckus that you disturb some bats sleeping on the ceiling.");
                            if (Player.batRepel == 1)
                            {
                                Console.WriteLine("You sprayed your bat repellant at the rabid bats so they left you alone.");
                                Player.batRepel -= 1;
                            }
                            else
                            {
                                Console.WriteLine("Oh no! There are rabid bats in this room. Their infection was your demise.");
                                Player.dead = true;
                                break;
                            }
                            break;
                        default:
                            break;
                    }


                    if (Wumpus.wRoom == Player.playerRoom)
                    {
                        //have Wumpus be able to kill player while occupying the same room
                        Console.WriteLine("You ran into a Wumpus!");
                        if (sleepyWumpus == true)
                        {
                            Console.WriteLine("He ate you right up.");
                            Player.dead = true;
                            Console.WriteLine("Thank you for playing Hunt the Wumpus! Hope you enjoyed your adventure!");
                            Environment.Exit(0);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    //if wumpus is close AND room has event, event will cease.
                    else if (Wumpus.wRoom + 1 == Player.playerRoom || Wumpus.wRoom - 1 == Player.playerRoom)
                    {
                        Console.WriteLine("There are faint wumpus prints.");
                    }
                    else if (Player.playerRoom > 12) //So player can't exceed the 20th room
                    {
                        Console.WriteLine("You try to go to room" + Player.playerRoom);
                        Console.Write("but there are only twenty rooms here! Pick a more realistic option.");
                        Player.playerRoom = 1;
                    }
                    else if (Player.playerRoom == Bats.bRoom1 || Player.playerRoom == Bats.bRoom1 || Player.playerRoom == Holes.hRoom1 || Player.playerRoom == Holes.hRoom2)
                    {
                        continue;
                    }
                    else if (Player.haveTracker)
                    {
                        //have player able to set down tracker
                        Console.WriteLine("There's nothing here, which means it would be a perfect place to put down your tracker. Would you like to set it down? \nYes (y) or No (n).");
                        if (Console.ReadLine() == "y" || Console.ReadLine() == "Y")
                        {
                            trackerRoom = Player.playerRoom;
                            Player.haveTracker = false;
                            Console.WriteLine("You have placed the tracker in room " + Player.playerRoom + ".");

                        }
                        else if (Console.ReadLine() == "n" || Console.ReadLine() == "N")
                        {
                            Console.WriteLine("You decide that the tracker is too precious to leave somewhere at random. You hold onto it for now.");
                        }
                        else
                        {
                            Console.WriteLine("Yes (y) or no (n).");
                            continue;
                        }
                    }
                    else
                    {
                        Console.WriteLine("There's nothing here. Best move along.");
                        continue;
                    }
                }

                //Shooty shooty bang bang
                else if (choice == "s")
                {
                    Console.WriteLine("You have " + Player.arrows + "." + "How many arrows do you want to shoot?");
                    int myShot = Int32.Parse(Console.ReadLine());

                    if (myShot <= Player.arrows)
                    {
                        Player.arrows -= myShot;

                        for (int i = 0; i < myShot; i++)
                        {
                            Console.WriteLine("You have " + (myShot - i) + " of the " + myShot + " arrows you have chosen to shoot left.");
                            Console.WriteLine("Where would you like to shoot this arrow? ");
                            //Console.Write("")

                            switch (Player.playerRoom)
                            {
                                case 1:
                                    Console.WriteLine("You can shoot into rooms 2, 4, 5, 6, 10.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 2:
                                    Console.WriteLine("You can shoot into rooms 1, 4, 7, 8, 10.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 3:
                                    Console.WriteLine("You can shoot into rooms 4, 6, 8, 11, 12.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 4:
                                    Console.WriteLine("You can shoot into rooms 1, 2, 3, 6, 8.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 5:
                                    Console.WriteLine("You can shoot into rooms 1, 6, 9, 10, 11.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 6:
                                    Console.WriteLine("You can shoot into rooms 1, 3, 4, 5, 11.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 7:
                                    Console.WriteLine("You can shoot into rooms 2, 8, 9, 10, 12.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 8:
                                    Console.WriteLine("You can shoot into rooms 2, 3, 4, 7, 12.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 9:
                                    Console.WriteLine("You can shoot into rooms 5, 7, 10, 11, 12.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 10:
                                    Console.WriteLine("You can shoot into rooms 1, 2, 5, 7, 9.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 11:
                                    Console.WriteLine("You can shoot into rooms 3, 5, 6, 9, 12.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                case 12:
                                    Console.WriteLine("You can shoot into rooms 3, 7, 8, 9, 11.");
                                    Player.roomShot = Int32.Parse(Console.ReadLine());
                                    if (Player.roomShot == Wumpus.wRoom)
                                    {
                                        Console.WriteLine("You caught the wumpus!");
                                        Wumpus.wDead = true;
                                        winnerWinner = true;
                                        Console.WriteLine("The wumpus is dead! But wait, he left something behind. This cave is hiding a treasure somewhere within it's walls. \n I heard that some of the bats here could fly you there, if only you could find the right ones...");
                                        break;
                                        //Console.WriteLine("Press enter to close this window.");
                                        //Environment.Exit(0);
                                    }
                                    else
                                    {
                                        Console.WriteLine("You hear the woosh of an arrow. You didn't hit anything.");
                                        break;
                                    }
                                default:
                                    Console.WriteLine("Please pick a surrounding room.");
                                    continue;

                            }
                            
                        }
                    }
                    else if (winnerWinner)
                    {
                        break;
                    }
                    // Can't shoot more arrows than given.
                    else
                    {
                        Console.WriteLine("Nice try, genius, but " + myShot + "is bigger than " + Player.arrows + ".");
                        
                    }
                }
                else
                {
                    Console.WriteLine("Please enter either 'm' or 's'.");
                    if(Player.arrows == 0)
                    {
                        Console.WriteLine("With no arrows to fight off the Wumpus and no help in sight, you can only await your impending doom in the caverns.");
                        Console.WriteLine("Thank you for playing Hunt the Wumpus! Hope you enjoyed your adventure!");
                        Environment.Exit(0);

                    }
                    else
                    {
                        continue;

                    }
                }
            }
            //TODO: End game
            Console.WriteLine("Thank you for playing Hunt the Wumpus! Hope you enjoyed your adventure!");
            Environment.Exit(0);
            
        }
    }
}
