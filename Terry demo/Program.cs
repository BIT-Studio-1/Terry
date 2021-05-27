using System;

namespace Command_Line_Adventure
{
    class Program
    {
        // These are universal variables 
        public static string temp;
        public static string tempItem;
        public static string item1 = "Empty", item2 = "Empty", item3 = "Empty";
        public static int strength, stealth, cunning, health;     
        //This bools allow to change the situation when you get to a room
        public static bool EmptyArmouryButton = false;
        public static bool GuardsChamberButton = false;
        //Item list
        

        // this is just a simplified method of the players stats just so theres something to test with in this demo
        public static int[] PlayerStats()
        {
            // slot 1 = Strength: slot 2 = Stealth: slot 3 = Cunning: slot 4 = Health;
            int[] PlayerStats = { strength, stealth, cunning, health };
            return PlayerStats;
        }



        public static int[] EnemyStats(int enemyNumber) // this method stores all the integer information of the enemys
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
        public static string[] EnemyDio(int enemyNumber) // this method stores all the string information for enemys
        {
            switch (enemyNumber)
            {
                case 1:                  // slot 1 = Introduction: slot 2 = if you hit the guard: slot 3 = if the guard hits you: slot 4 = if you beat the guard: slot 5 = if the guard beats you: slot 6 = name
                    string[] GuardDio = { "The Guard spots you!\n\nGuard: Stop! in the name of the law, your under arest", "Guard: Bastard!", "Guard: Take that", "Guard: I . need .. back up ...", "Guard: Its back to the cell for you", "Guard" };
                    return GuardDio;
                case 2:
                    string[] OgreDio = { "Before you stands an Ogre. Huge and threating, the Ogre yells \n\nOgre: Im gonna eat you!", "Ogre: Ourghhh! you hit me!", "Ogre: hehe get in me belly", "Ogre: ARGGHH *thud*\nThe Ogre falls, shacking the ground you stand on, \nthe bigger they are the harder they fall\nYou find a very sharp blade on his belt\nYour strength is increased", "Ogre: Finaly! Dinner\nThe Ogre drags you to his lair where he prepares his dinner\nYou are eaten, luckily you bled to death before that happened", "Ogre" };
                    return OgreDio;
                default:
                    break;
            }
            string[] Null = { "silence", "silence", "silence", "silence", "silence", "silence" };
            return Null;
        }
        // this method will get opened up whenever theres a battle
        public static bool Battle(int scenarioNumber, string PlaceName)
        {
            string temp1;
            int decision;
            Random randy = new Random();

            string placeName = PlaceName;
            int[] enemyStats = EnemyStats(scenarioNumber);
            string[] enemyDis = EnemyDio(scenarioNumber);



            // slot 1 = Strength: slot 2 = Stealth: slot 3 = Cunning: slot 4 = Health
            // eventually "enemyStats" will be like "playerStats"
            int[] playerStats = PlayerStats();

            Console.WriteLine(enemyDis[0]);
            Console.ReadLine();

            // this while loop will stay running while the players health does not reach 0
            while (playerStats[3] != 0)
            {
                Console.Clear();

                // shows the players and enemys health <3
                Console.WriteLine("Your Health: " + playerStats[3]);
                Console.WriteLine(enemyDis[5] + " Health: " + enemyStats[3] + "\n");

                // Choices 2 and 3 do nothing
                Console.WriteLine("1: Attack the " + enemyDis[5]);
                Console.WriteLine("2: Hide from the " + enemyDis[5]);
                Console.WriteLine("3: something to do with cunning (leads nowhere)\n");
                temp1 = Console.ReadLine();
                decision = Convert.ToInt32(temp1);

                Console.Clear();

                // this happens if you choose to battle
                if (decision == 1)
                {
                    // total rolls of both charcters will be compared to determine who hits who
                    int yourRoll = 0, enemyRoll = 0;

                    // shows your strength stat, that stat is how much dice you roll
                    Console.WriteLine("You attack with " + playerStats[0] + " dice");
                    Console.ReadLine();

                    // this for loop runs as many times as your strength stat
                    for (int i = 0; i < playerStats[0]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        yourRoll = yourRoll + dice;
                    }

                    Console.WriteLine("\nThe " + enemyDis[5] + " attacks with " + enemyStats[0] + " dice"); // finds info on enemys name and strength stat
                    Console.ReadLine();

                    // same as above
                    for (int i = 0; i < enemyStats[0]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        enemyRoll = enemyRoll + dice;
                    }

                    Console.ReadLine();
                    Console.WriteLine("Your total strength is " + yourRoll);
                    Console.ReadLine();

                    Console.WriteLine("The " + enemyDis[5] + "s total strength is " + enemyRoll);
                    Console.ReadLine();

                    if (yourRoll > enemyRoll)
                    {
                        // if your total is greater then the enemys, you hit the enemy and deal 1 damage to his health, and he says a line
                        enemyStats[3] = enemyStats[3] - 1;
                        Console.WriteLine("You hit the " + enemyDis[5]);
                        Console.WriteLine(enemyDis[1]);
                        Console.ReadLine();
                    }

                    if (yourRoll < enemyRoll)
                    {
                        // if your total roll is lesser then the enemys, you lose 1 health and he says a line again
                        playerStats[3] = playerStats[3] - 1;
                        Console.WriteLine("The " + enemyDis[5] + " hits you");
                        Console.WriteLine(enemyDis[2]);
                        Console.ReadLine();
                    }

                    if (playerStats[3] == 0)
                    {
                        Console.WriteLine(enemyDis[4]);
                        Console.ReadLine();
                    }

                    if (enemyStats[3] == 0)
                    {
                        Console.WriteLine(enemyDis[3]);
                        Console.ReadLine();
                        
                        break;
                    }
                    
                }

                if (decision == 2)
                {
                    int yourRoll = 0, enemyRoll = 0;

                    // shows your strength stat, that stat is how much dice you roll
                    Console.WriteLine("You try hide, you use " + playerStats[1] + " dice");
                    Console.ReadLine();

                    // this for loop runs as many times as your strength stat
                    for (int i = 0; i < playerStats[1]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        yourRoll = yourRoll + dice;
                    }

                    Console.WriteLine("\nThe " + enemyDis[5] + " checks with " + enemyStats[1] + " dice"); // finds info on enemys name and strength stat
                    Console.ReadLine();

                    // same as above
                    for (int i = 0; i < enemyStats[1]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        enemyRoll = enemyRoll + dice;
                    }

                    Console.ReadLine();
                    Console.WriteLine("Your total stealth roll is " + yourRoll);
                    Console.ReadLine();

                    Console.WriteLine("The " + enemyDis[5] + "s total stealth is " + enemyRoll);
                    Console.ReadLine();

                    if (yourRoll > enemyRoll)
                    {
                        Console.WriteLine("You hide from the " + enemyDis[5]);
                        Console.WriteLine(enemyDis[5] + ": where did you go?");
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
                        Console.WriteLine("You unsuccsesfully hide and the " + enemyDis[5] + " hits you");
                        Console.WriteLine(enemyDis[2]);
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

        public static void PickItem() {
            string temp;
            int input;
            string input2 = "y";
            do
            {
                Console.WriteLine("Choose a slot for the item ");
                Console.WriteLine($" [1] Slot 1: {item1}");
                Console.WriteLine($" [2] Slot 2: {item2}");
                Console.WriteLine($" [3] Slot 3: {item3}");

                input2 = "y";
                temp = Console.ReadLine();
                input = Convert.ToInt32(temp);
                switch (input)
                {
                    case 1:
                        if (item1 != "Empty")
                        {
                            Console.WriteLine($"Are you sure you want to replace the {item1} for the {tempItem}? y/n");
                            input2 = Console.ReadLine();
                            if (input2 == "y")
                            {
                                item1 = tempItem;
                            }
                        }
                        else {
                            item1 = tempItem;
                        }                        
                        break;
                    case 2:
                        if (item2 != "Empty")
                        {
                            Console.WriteLine($"Are you sure you want to replace the {item2} for the {tempItem}? y/n");
                            input2 = Console.ReadLine();
                            if (input2 == "y")
                            {
                                item2 = tempItem;
                            }
                        }
                        else
                        {
                            item2 = tempItem;
                        }
                        break;
                    case 3:
                        if (item3 != "Empty")
                        {
                            Console.WriteLine($"Are you sure you want to replace the {item3} for the {tempItem}? y/n");
                            input2 = Console.ReadLine();
                            if (input2 == "y") {
                                item3 = tempItem;                              
                            }                   
                        }
                        else
                        {
                            item3 = tempItem;
                        }
                        break;
                    default:
                        Console.WriteLine("Wrong command ");
                        break;

                }
            } while ((input != 1) && (input != 2) && (input != 3) || (input2 == "n"));
            
            Console.WriteLine($"You picked the {tempItem}");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();


        }
        public static void Inventory()
        {

            Console.WriteLine();
            Console.WriteLine("~Inventory~");
            Console.WriteLine("-----------");
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
            Console.WriteLine("You are in the Crematorium");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] something");
            Console.WriteLine("- [3] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    LeftHallway();
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
                    tempItem = "Key";
                    PickItem();
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
                    tempItem = "Rusty Sword";
                    PickItem();
                    strength++;
                    
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
                    tempItem = "The King's Sword"; //PLEACEHOLDER
                    PickItem();
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