using System;
using System.Threading;

namespace Command_Line_Adventure
{
    class Program
    {
        // These are universal variables 
        public static string temp;
        public static string item1 = "Empty", item2 = "Empty", item3 = "Empty";
        public static int strength, stealth, cunning, health, Weapon, Clothing;     
        public static bool EmptyArmouryButton = false;
        public static bool GuardsChamberButton = false;

        public static int[] PlayerStats()
        {
            // slot 1 = Strength: slot 2 = Stealth: slot 3 = Cunning: slot 4 = Health;
            int[] PlayerStats = { strength, stealth, cunning, health };
            return PlayerStats;
        }

        public static int[] StatsCalculation()
        {
            int[] finalStats = { 0, 0, 0, 0 };

            int[] weaponStats = weapon(Weapon);

            int[] clothingStats = clothing(Clothing);

            int[] playerStats = PlayerStats();
            for (int i = 0; i < playerStats.Length; i++)
            {
                finalStats[i] = playerStats[i] + weaponStats[i] + clothingStats[i];
            }

            return finalStats;
        }

        public static int[] weapon(int weaponNumber)
        {
            switch (weaponNumber)
            {
                case 1:
                    int[] rustySword = { 1, 0, 0, 0 };
                    return rustySword;
            }
            int[] Null = { 0, 0, 0, 0 };
            return Null;
        }

        public static int[] clothing(int clothingNumber)
        {
            switch (clothingNumber)
            {
                case 1:
                    int[] LeatherAmour = { 0, 1, 0, 1 };
                    return LeatherAmour;
            }
            int[] Null = { 0, 0, 0, 0 };
            return Null;
        }

        public static int[] EnemyStats(int enemyNumber)
        {
            switch (enemyNumber)
            {
                case 1:
                    int[] GuardStats = { 2, 2, 1, 3 };
                    return GuardStats;
                case 2:
                    int[] OgreStats = { 4, 1, 1, 4 };
                    return OgreStats;

            }
            int[] Null = { 0, 0, 0, 0 };
            return Null;
        }
        public static string[] EnemyBarks(int enemyNumber)
        {
            switch (enemyNumber)
            {
                case 1:                  // slot 1 = Introduction: slot 2 = if you hit the guard: slot 3 = if the guard hits you: slot 4 = if you beat the guard: slot 5 = if the guard beats you: slot 6 = name
                    string[] GuardBarks = { "The Guard spots you!\n\nGuard: Stop! in the name of the law, your under arest", "Guard: Bastard!", "Guard: Take that", "Guard: I . need .. back up ...", "Guard: Its back to the cell for you", "Guard" };
                    return GuardBarks;
                case 2:
                    string[] OgreBarks = { "Before you stands an Ogre. Huge and threating, the Ogre yells \n\nOgre: Im gonna eat you!", "Ogre: Ourghhh! you hit me!", "Ogre: hehe get in me belly", "Ogre: ARGGHH *thud*\nThe Ogre falls, shacking the ground you stand on, \nthe bigger they are the harder they fall\nYou find a very sharp blade on his belt\nYour strength is increased", "Ogre: Finaly! Dinner\nThe Ogre drags you to his lair where he prepares his dinner\nYou are eaten, luckily you bled to death before that happened", "Ogre" };
                    return OgreBarks;
                default:
                    break;
            }
            string[] Null = { "silence", "silence", "silence", "silence", "silence", "silence" };
            return Null;
        }

        // ** ALL STATS AND BARKS ABOVE THIS POINT ** //
        
        public static bool Battle(int scenarioNumber, string PlaceName)
        {
            string temp1;
            int decision;
            Random randy = new Random();
            string placeName = PlaceName;
            int[] enemyStats = EnemyStats(scenarioNumber);
            string[] enemyBarks = EnemyBarks(scenarioNumber);
            int[] playerStats = PlayerStats();
            Console.WriteLine(enemyBarks[0]);
            Console.ReadLine();
            while (playerStats[3] != 0)
            {
                Console.Clear();
                Console.WriteLine("Your Health: " + playerStats[3]);
                Console.WriteLine(enemyBarks[5] + " Health: " + enemyStats[3] + "\n");
                Console.WriteLine("1: Attack the " + enemyBarks[5]);
                Console.WriteLine("2: Hide from the " + enemyBarks[5]);
                Console.WriteLine("3: something to do with cunning (leads nowhere)\n");
                temp1 = Console.ReadLine();
                decision = Convert.ToInt32(temp1);
                Console.Clear();
                if (decision == 1)
                {
                    int yourRoll = 0, enemyRoll = 0;
                    Console.WriteLine("You attack with " + playerStats[0] + " dice");
                    Console.ReadLine();
                    for (int i = 0; i < playerStats[0]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        yourRoll = yourRoll + dice;
                    }
                    Console.WriteLine("\nThe " + enemyBarks[5] + " attacks with " + enemyStats[0] + " dice");
                    Console.ReadLine();
                    for (int i = 0; i < enemyStats[0]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        enemyRoll = enemyRoll + dice;
                    }
                    Console.ReadLine();
                    Console.WriteLine("Your total strength is " + yourRoll);
                    Console.ReadLine();
                    Console.WriteLine("The " + enemyBarks[5] + "s total strength is " + enemyRoll);
                    Console.ReadLine();
                    if (yourRoll > enemyRoll)
                    {
                        enemyStats[3] = enemyStats[3] - 1;
                        Console.WriteLine("You hit the " + enemyBarks[5]);
                        Console.WriteLine(enemyBarks[1]);
                        Console.ReadLine();
                    }
                    if (yourRoll < enemyRoll)
                    {
                        playerStats[3] = playerStats[3] - 1;
                        Console.WriteLine("The " + enemyBarks[5] + " hits you");
                        Console.WriteLine(enemyBarks[2]);
                        Console.ReadLine();
                    }
                    if (playerStats[3] == 0)
                    {
                        Console.WriteLine(enemyBarks[4]);
                        Console.ReadLine();
                    }
                    if (enemyStats[3] == 0)
                    {
                        Console.WriteLine(enemyBarks[3]);
                        Console.ReadLine();
                        break;
                    }
                }
                if (decision == 2)
                {
                    int yourRoll = 0, enemyRoll = 0;
                    Console.WriteLine("You try hide, you use " + playerStats[1] + " dice");
                    Console.ReadLine();
                    for (int i = 0; i < playerStats[1]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        yourRoll = yourRoll + dice;
                    }
                    Console.WriteLine("\nThe " + enemyBarks[5] + " checks with " + enemyStats[1] + " dice");
                    Console.ReadLine();
                    for (int i = 0; i < enemyStats[1]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        enemyRoll = enemyRoll + dice;
                    }
                    Console.ReadLine();
                    Console.WriteLine("Your total stealth roll is " + yourRoll);
                    Console.ReadLine();
                    Console.WriteLine("The " + enemyBarks[5] + "s total stealth is " + enemyRoll);
                    Console.ReadLine();
                    if (yourRoll > enemyRoll)
                    {
                        Console.WriteLine("You hide from the " + enemyBarks[5]);
                        Console.WriteLine(enemyBarks[5] + ": where did you go?");
                        Console.ReadLine();
                        Console.WriteLine("Do you want to run away?\n1: Yes\n2: No\n");
                        temp1 = Console.ReadLine();
                        decision = Convert.ToInt32(temp1);
                        if (decision == 1)
                        {
                            Console.WriteLine("You escape the " + placeName);
                            return true;
                        }
                    }
                    if (yourRoll < enemyRoll)
                    {
                        playerStats[3] = playerStats[3] - 1;
                        Console.WriteLine("You unsuccsesfully hide and the " + enemyBarks[5] + " hits you");
                        Console.WriteLine(enemyBarks[2]);
                        Console.ReadLine();
                    }
                }
                if (decision == 3)
                {
                    // something happens, not yet implimented
                }
            }
            Console.Clear();
            return true; // this means nothing right now
        }





        public static void Inventory()
        {

            Console.WriteLine();
            Console.WriteLine("~Inventory~");
            Console.WriteLine("-----------");
            Console.WriteLine($"  Weapon : {item1}");
            Console.WriteLine($"  Slot 1 : {item1}");
            Console.WriteLine($"  Slot 2 : {item2}");
            Console.WriteLine($"  Slot 3 : {item3}");
            Console.WriteLine();
            Console.WriteLine("~Statistics~");
            Console.WriteLine("------------");
            Console.WriteLine($"  Strength : {strength}");
            Console.WriteLine($"  Stealth  : {stealth}");
            Console.WriteLine($"  Cunning  : {cunning}");
            Console.WriteLine($"  Health   : {health}");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }

        public static void Dungeon()
        {
            string temp;
            int input;

            do
            {


                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Your options are...");
                Console.WriteLine("- [1] Go Investigate the Hallway");
                Console.WriteLine("- [2] Stay Imprisoned");
                Console.WriteLine("- [3] Check Inventory");
                Console.WriteLine();

                temp = Console.ReadLine();
                input = Convert.ToInt32(temp);
                Console.Clear();

                switch (input)
                {
                    case 1:
                        NorthMiddleHallway();
                        break;
                    case 2:
                        Console.WriteLine("You chose to stay. And with that your, only chance of escape is gone. The Guards walk into the dungeon \nYou die later that night");
                        Console.ReadLine();
                        break;
                    case 3:
                        Inventory();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("You have entered an invalid input");
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadLine();
                        break;
                }
            } while (input != 0);
        }
        public static void NorthMiddleHallway()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Hallway");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go back into the Dungeon");
            Console.WriteLine("- [2] Go  Left <--");
            Console.WriteLine("- [3] Go  Right -->");
            Console.WriteLine("- [4] Check Inventory");
            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    Dungeon();
                    break;
                case 2:
                    LeftHallway();
                    break;
                case 3:
                    RightHallway();
                    break;

                case 4:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    NorthMiddleHallway();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void LeftHallway()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the North West part of the Hallway\n");
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go  Right -->");
            Console.WriteLine("- [2] Enter Armoury with Guards ");
            Console.WriteLine("- [3] Enter the Crematorium ");
            Console.WriteLine("- [4] Go  Down");
            Console.WriteLine("- [5] Check Inventory");
            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    NorthMiddleHallway();
                    break;
                case 2:
                    if (GuardsChamberButton == false)
                    {
                        GuardsChamber();
                    }
                    else
                    {
                        GuardsChamberB();
                    }
                    break;
                case 3:
                    Crematorium();
                    break;
                case 4:
                    Southwesthallway();
                    break;
                case 5:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    LeftHallway();
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void RightHallway()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the North East part of the Hallway\n");
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go  Left <--");
            Console.WriteLine("- [2] Enter Lair of the Beast ");
            Console.WriteLine("- [3] Enter the Mystery Room ");
            Console.WriteLine("- [4] Go  Down (South)");
            Console.WriteLine("- [5] Check Inventory");
            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    NorthMiddleHallway();
                    break;
                case 2:                   
                    Lairofthebeast();
                    break;
                case 3:
                    if ((item1 == "Key") || (item1 == "Key") || (item1 == "Key"))
                    {
                        do
                        {
                            Console.WriteLine("The door is locked. Use the key? y/n ");
                            temp = Console.ReadLine();
                            if (temp == "y")
                            {
                                Lockedmysteryroom();
                            }
                            else if (temp == "n")
                            {
                                RightHallway();
                            }
                            else
                            {
                                Console.WriteLine("Wrong command");
                            }
                        }while((temp != "y") || (temp != "n"));
                    }
                    else {
                        Console.WriteLine("The door is locked. You need the key to open it...");
                        Console.ReadLine();
                        RightHallway();
                    }
                    break;
                case 4:
                    Southeasthallway();
                    break;

                case 5:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    RightHallway();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void Crematorium()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Crematorium, It is dark and gloomy and you cough because of all the ash.");
            Console.WriteLine("Memories of your parents come back to you, they met a cruel demise at the hands of the king.");
            Console.WriteLine("The king will pay for this injustice you say to yourself as you prepare to find some of their");
            Console.WriteLine("remains here in the Crematorium");
            Console.WriteLine();
            
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] Search the crematorium oven");
            Console.WriteLine("- [3] Check Inventory");
            Console.WriteLine();
            Thread.Sleep(1000);
            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    LeftHallway();
                    break;
                case 2:
                    Console.WriteLine("You find a large pile of ashes in the oven and you notice your deceased father's lucky ring.");
                    Console.WriteLine("Would you like to take your father's ring? 'y' for yes 'n' for no");
                    temp = Console.ReadLine();
                    if(temp == "y")
                    {
                        Console.WriteLine("You have picked up your fathers lucky ring");
                        //tempItem = "Father's ring";
                        //Need a number for the ring
                        cunning++;
                    }
                    break;


                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Crematorium();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        
        public static void CrematoryB()
        {









        }
        
        
        public static void GuardsChamber()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Guards chamber. It seems like only one guard is here. You see a key hanging from his belt.");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] Take a chance and fight!");
            Console.WriteLine("- [3] Check Inventory");
            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            int Scenario = 1;
            string PlaceName = "Guards Chamber";

            switch (input)
            {
                case 1:
                    LeftHallway();
                    break;

                case 2:
                    Battle(Scenario,PlaceName);
                    //tempItem = "Key";
                    // need a number for the key
                    GuardsChamberButton = true;
                    if (GuardsChamberButton == false)
                    {
                        GuardsChamber();
                    }
                    else
                    {
                        GuardsChamberB();
                    }
                    break;

                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    GuardsChamber();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void GuardsChamberB()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Guards chamber. The room is empty.");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] Check Inventory");
            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    LeftHallway();
                    break;

                case 2:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    GuardsChamberB();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void Lairofthebeast()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Lair Of The Beast");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] What's that strange sound???");
            Console.WriteLine("- [3] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    RightHallway();
                    break;

                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Lairofthebeast();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void Lockedmysteryroom()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Locked Mystery Room");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [3] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    RightHallway();
                    break;

                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Lockedmysteryroom();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void Southeasthallway()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are South East part of the hallway");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go Up (North)");
            Console.WriteLine("- [2] Go  Left <--");
            Console.WriteLine("- [3] Enter the Armoury");
            Console.WriteLine("- [4] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    RightHallway();
                    break;
                case 2:
                    Southwesthallway();
                    break;
                case 3:
                    if (EmptyArmouryButton == false)
                    {
                        EmptyArmoury();
                    }
                    else
                    {
                        EmptyArmouryB();
                    }
                    break;
                case 4:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Southeasthallway();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void EmptyArmoury()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Armoury. All weapons are gone but it seems to be a 'Rusty sword' in one corner ");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] Take the sword");
            Console.WriteLine("- [3] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    Southeasthallway();
                    break;
                case 2:

                    Weapon = 1;
                    EmptyArmouryButton = true;
                    
                    EmptyArmouryB();
                    break;
                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    if (EmptyArmouryButton == false)
                    {
                        EmptyArmoury();
                    }
                    else
                    {
                        EmptyArmouryB();
                    }
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void EmptyArmouryB()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Armoury. All weapons are gone... ");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    Southeasthallway();
                    break;

                case 2:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    EmptyArmouryB();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void Southwesthallway()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are South West part of the hallway");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go  Up (North)");
            Console.WriteLine("- [2] Go  Right -->");
            Console.WriteLine("- [3] Enter the Heavy dungeon");
            Console.WriteLine("- [4] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    LeftHallway();
                    break;
                case 2:
                    Southeasthallway();
                    break;
                case 3:
                    Heavydungeon();
                    break;
                case 4:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Southwesthallway();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }
        public static void Heavydungeon()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Heavy Dungeon");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");

            Console.WriteLine("- [3] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    Southwesthallway();
                    break;
                //  case 2:
                //     break;
                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Heavydungeon();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }

        public static void BetterArmory()
            // ROOM CURRENTLY NOT CONNECTED TO ANYTHING
            // CAN'T BE TESTED UNTIL CONNECTED
        {
            string temp;
            int input;
            Console.Clear();
            Console.WriteLine("You are in the Better Armory");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards"); //NEEDS TO BE CONNECTED TO HALLWAY SECOND FLOOR
            Console.WriteLine("- [2] Check the Chest "); 
            Console.WriteLine("- [3] option3"); // CHECK CHEST?
            Console.WriteLine("- [4] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                //case 1:
  
                case 2:
                    //tempItem = "The King's Sword"; //PLEACEHOLDER
                    // need a number for it
                    strength = strength + 2;
                    Console.WriteLine("You have picked up The King's Sword");
                    break;

                // case 3:
                //empty 

                case 4:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    BetterArmory();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }

        public static void BetterArmoryB()
        // ROOM CURRENTLY NOT CONNECTED TO ANYTHING
        // CAN'T BE TESTED UNTIL CONNECTED
        // EMPTY ROOM!!!!!!!!!!
        {
            string temp;
            int input;
            Console.Clear();
            Console.WriteLine("You are in the Better Armory");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards"); //NEEDS TO BE CONNECTED TO HALLWAY SECOND FLOOR
            Console.WriteLine("- [2] Check the Chest ");
            Console.WriteLine("- [3] option3"); // CHECK CHEST?
            Console.WriteLine("- [4] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                //case 1:

                case 2:
                    Console.WriteLine("The Chest is empty");
                    break;

                // case 3:
                //empty 

                case 4:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    BetterArmoryB();
                    break;

                default:
                    Console.WriteLine();
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadLine();
                    break;
            }
        }

        public static void Main()
        {
            int Character;

            do
            {
                Console.WriteLine("Choose a character: ");
                Console.WriteLine("Select: 1 for Strength, 2 for Stealth or 3 for Cunning.");
                Console.WriteLine();
                Console.WriteLine("       1 - Strength       2 - Stealth        3 - Cunning");
                Console.WriteLine("          ----------         ---------          ---------");
                Console.WriteLine("Strength:     3                  1                  1     ");
                Console.WriteLine("Stealth :     1                  4                  1     ");
                Console.WriteLine("Cunning :     1                  2                  4     ");
                Console.WriteLine("Health  :     4                  2                  3     ");


                temp = Console.ReadLine();
                Character = Convert.ToInt32(temp);
                Console.WriteLine();
                switch (Character)
                {
                    case 1:
                        strength = 3;
                        stealth = 1;
                        cunning = 1;
                        health = 4;
                        Console.WriteLine("You chose Strength. ");

                        break;

                    case 2:
                        strength = 1;
                        stealth = 4;
                        cunning = 2;
                        health = 2;
                        Console.WriteLine("You chose Stealth. ");

                        break;

                    case 3:
                        strength = 1;
                        stealth = 1;
                        cunning = 4;
                        health = 3;
                        Console.WriteLine("You chose Cunning. ");

                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("Wrong command. ");
                        Console.WriteLine("PRESS ENTER");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }

            } while ((Character != 1) && (Character != 2) && (Character != 3));
            Console.WriteLine("Type 1 to check your stats or press Enter to continue. ");
            temp = Console.ReadLine();
            if (temp == "1")
            {
                Inventory();
            }
            Console.Clear();
            Console.WriteLine("You wake up in a dark and dilapidated Dungeon, With no idea how you got here. \nYou hear the screams of other prisoners echoing the halls\nHowever you see a faint light in the distance and notice that the door is slightly open.  ");
            Console.ReadLine();
            Dungeon();

            Console.ReadLine();

        }
    
    
    
    
    
    
    
    }
}