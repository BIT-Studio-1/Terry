using System;

namespace Command_Line_Adventure
{
    class Program
    {
        // These are universal variables 
        public static string temp;
        public static string item1 = "Empty", item2 = "Empty", item3 = "Empty";
        public static int strength, stealth, cunning, health = 3;     
        //This bools allow to change the situation when you get to a room
        public static bool EmptyArmouryButton = false;
        public static bool GuardsChamberButton = false;

        // this is just a simplified method of the players stats just so theres something to test with in this demo
        public static int[] PlayerStats()
        {
            // slot 1 = Strength: slot 2 = Stealth: slot 3 = Cunning: slot 4 = Health;
            int[] PlayerStats = { strength, stealth, cunning, health };
            return PlayerStats;
        }



        // this method will get opened up whenever theres a battle
        public static bool Battle()
        {
            string temp1;
            int decision, temp2;
            Random randy = new Random();



            // this is just a temperary variable, but this can be swapped out with other information eventually. its filled with things like diolage options and its name  
            // slot 1 = Introduction: slot 2 = if you hit the guard: slot 3 = if the guard hits you: slot 4 = if you beat the guard: slot 5 = if the guard beats you: slot 6 = name
            string[] enemyDis = { "you are confronted by a dungeon Guard \nGuard: Stop in the name of the law", "Guard: Arrgh", "Guard: Haha", "Guard: I . need .. back up ...", "Guard: Its been a while since ive had a good brawl", "Guard" };



            // slot 1 = Strength: slot 2 = Stealth: slot 3 = Cunning: slot 4 = Health
            int[] enemyStats = { 2, 2, 1, 2 }; // eventually "enemyStats" will be like "playerStats"
            int[] playerStats = PlayerStats();



            // this while loop will stay running while the players health does not reach 0
            while (playerStats[3] != 0)
            {
                // shows the players and enemys health <3
                Console.WriteLine("Your <3 = " + playerStats[3]);
                Console.WriteLine(enemyDis[5] + " <3 = " + enemyStats[3]);
                Console.ReadLine();



                // Choices 2 and 3 do nothing
                Console.WriteLine("1: Attack the " + enemyDis[5]);
                Console.WriteLine("2: Hide from the " + enemyDis[5]);
                Console.WriteLine("3: do stuff");
                temp1 = Console.ReadLine();
                decision = Convert.ToInt32(temp1);


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

                    Console.ReadLine();
                    Console.WriteLine("The " + enemyDis[5] + " attacks with " + enemyStats[0] + " dice"); // finds info on enemys name and strength stat
                    Console.ReadLine();

                    // same as above
                    for (int i = 0; i < enemyStats[0]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        enemyRoll = enemyRoll + dice;
                    }

                    Console.ReadLine();
                    Console.WriteLine("Your total roll is " + yourRoll);
                    Console.ReadLine();

                    Console.WriteLine("The " + enemyDis[5] + "s total roll is " + enemyRoll);
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

                }

                if (decision == 2)
                {
                    // something stealth related happens, not yet implimented
                }

                if (decision == 3)
                {
                    // something happens, not yet implimented
                }

            }



            return true; // this means nothing right now
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
                Console.WriteLine("You are in the Dungeon");
                Console.WriteLine();
                Console.WriteLine("Your options are...");
                Console.WriteLine("- [1] Go to the Hallway");
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
                        Console.WriteLine("You die later that night");
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
            Console.WriteLine("You are in the North West part of the Hallway");
            Console.WriteLine();
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
            Console.WriteLine("You are in the North East part of the Hallway");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go  Left <--");
            Console.WriteLine("- [2] Enter Lair of the Beast ");
            Console.WriteLine("- [3] Enter the Locked Mystery Room ");
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
                    Lockedmysteryroom();
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

            switch (input)
            {
                case 1:
                    LeftHallway();
                    break;

                case 2:
                    Battle();
                    GuardsChamberButton = true;
                    if (EmptyArmouryButton == false)
                    {
                        EmptyArmoury();
                    }
                    else
                    {
                        EmptyArmouryB();
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
                    item1 = "Rusty Sword";
                    strength++;
                    Console.WriteLine("You picked up the 'Rusty Sword'. Strength up +1.");
                    Console.WriteLine("Press Enter to continue...");
                    EmptyArmouryButton = true;
                    Console.ReadLine();
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
                Console.WriteLine("Stealth:      1                  3                  1     ");
                Console.WriteLine("Cunning:      1                  1                  3     ");



                temp = Console.ReadLine();
                Character = Convert.ToInt32(temp);
                Console.WriteLine();
                switch (Character)
                {
                    case 1:
                        strength = 3;
                        stealth = 1;
                        cunning = 1;
                        Console.WriteLine("You chose Strength. ");

                        break;

                    case 2:
                        strength = 1;
                        stealth = 3;
                        cunning = 1;
                        Console.WriteLine("You chose Stealth. ");

                        break;

                    case 3:
                        strength = 1;
                        stealth = 1;
                        cunning = 3;
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


            Dungeon();

            Console.ReadLine();
        }
    }
}