using System;
using System.Threading;

namespace Command_Line_Adventure
{
    class Program
    {
        // These are universal variables 
        public static string temp;
        public static int[] stats = { 0, 0, 0, 0 };
        public static string keySlot = "...";
        public static int strength = stats[0], stealth = stats[1], cunning = stats[2], health = stats[3], Weapon, Clothing, Item;
        public static bool EmptyArmouryButton = false;
        public static bool GuardsChamberButton = false;
        public static bool LockedmysteryroomButton = false;
        public static bool GreatHallButton = false;
        public static bool BetterArmoryButton = false;

        public static void GameOver()
        {
            Console.WriteLine("You have been fatally wounded. You bleed out on the floor.");
            Console.WriteLine(@" 


 ██████   █████  ███    ███ ███████      ██████  ██    ██ ███████ ██████  
██       ██   ██ ████  ████ ██          ██    ██ ██    ██ ██      ██   ██ 
██   ███ ███████ ██ ████ ██ █████       ██    ██ ██    ██ █████   ██████  
██    ██ ██   ██ ██  ██  ██ ██          ██    ██  ██  ██  ██      ██   ██ 
 ██████  ██   ██ ██      ██ ███████      ██████    ████   ███████ ██   ██ ");
            Console.ReadLine();
            Main();
        }
        public static int[] PlayerStats()
        {
            // slot 1 = Strength: slot 2 = Stealth: slot 3 = Cunning: slot 4 = Health;
            int[] PlayerStats = { strength, stealth, cunning, health };
            return PlayerStats;
        }

        public static int[] StatsCalculation() // Player stats + Weapon stats + Clothing stats = your stats
        {
            int[] finalStats = { 0, 0, 0, 0 };

            int[] weaponStats = weapon(ref Weapon);

            int[] clothingStats = clothing(Clothing);

            int[] otherItemStats = other_Items(Item);

            int[] playerStats = PlayerStats();
            for (int i = 0; i < playerStats.Length; i++)
            {
                finalStats[i] = playerStats[i] + weaponStats[i] + clothingStats[i] + otherItemStats[i];
            }

            return finalStats;
        }

        public static int[] weapon(ref int weaponNumber)
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
        public static string[] weaponString(int weaponNumber)
        {
            switch (weaponNumber)
            {
                case 1:
                    string[] rustySword = { "~Rusty Sword~", "Old and rusted but still effective", "Strength +1" };
                    return rustySword;
            }
            string[] Null = { "...", "..." };
            return Null;
        }

        public static int[] clothing(int clothingNumber) // List of clothing stats
        {
            switch (clothingNumber)
            {
                case 2:
                    int[] Rags = { 0, 0, 0, 0 };
                    return Rags;
                case 1:
                    int[] LeatherAmour = { 0, 1, 0, 1 };
                    return LeatherAmour;
                case 3:
                    int[] GuardsArmour = { 0, 0, 0, 2 };
                    return GuardsArmour;
            }
            int[] Null = { 0, 0, 0, 0 };
            return Null;
        }

        public static string[] clothingString(int clothingNumber)
        {
            switch (clothingNumber)
            {
                case 1:
                    string[] Rags = { "~Rags~", "Worn and tattered, they provide little protection and warmth" };
                    return Rags;
                case 2:
                    string[] LeatherArmour = { "~Leather Amour~", "A sturdy set of leather clothing, it provides a bit of protection while also being light" };
                    return LeatherArmour;
                case 3:
                    string[] GuardsArmour = { "~Guard's Armor~", "Nice quality steel armor, it will protect you in your way out of here", "Health +2" };
                    return GuardsArmour;
            }
            string[] Null = { "...", "..." };
            return Null;
        }

        public static int[] other_Items(int itemNumber) // List of other items stats
        {
            switch (itemNumber)
            {
                case 1:
                    int[] Fathers_ring = { 0, 0, 1, 0 };
                    return Fathers_ring;

            }
            int[] Null = { 0, 0, 0, 0 };
            return Null;
        }
        public static string[] otherItemsString(int weaponNumber)
        {
            switch (weaponNumber)
            {
                case 1:
                    string[] Fathers_ring = { "~Father's ring~", "Your father had a way with words your cunning increases.", "Cunning +1" };
                    return Fathers_ring;
            }
            string[] Null = { "...", "..." };
            return Null;
        }
        public static int[] EnemyStats(int enemyNumber) // List of enemy stats
        {
            switch (enemyNumber)
            {
                case 1:       //Strength - Stealth - cunning - Health - SeduceRoll - IntimidateRoll - PersuadeRoll - TrickRoll 
                    int[] GuardStats = { 2, 2, 2, 3, 4, 3, 3, 2};
                    return GuardStats;
                case 2:
                    int[] OgreStats = { 4, 1, 1, 4 };
                    return OgreStats;
                case 3:
                    int[] ChefStats = { 3, 3, 4, 4 };
                    return ChefStats;

            }
            int[] Null = { 0, 0, 0, 0 };
            return Null;
        }
        public static string[] EnemyBarks(int enemyNumber) // List of enemy barks
        {
            switch (enemyNumber)
            {
                case 1:                  // slot 1 = Introduction: slot 2 = if you hit the guard: slot 3 = if the guard hits you: slot 4 = if you beat the guard: slot 5 = if the guard beats you: slot 6 = name
                    string[] GuardBarks = { "The Guard spots you!\n\nGuard: Stop! in the name of the law, your under arest", "Guard: Bastard!", "Guard: Take that", "Guard: I . need .. back up ...", "Guard: Its back to the cell for you", "Guard" };
                    return GuardBarks;
                case 2:
                    string[] OgreBarks = { "Before you stands an Ogre. Huge and threating, the Ogre yells \n\nOgre: Im gonna eat you!", "Ogre: Ourghhh! you hit me!", "Ogre: hehe get in me belly", "Ogre: ARGGHH *thud*\nThe Ogre falls, shacking the ground you stand on, \nthe bigger they are the harder they fall\nYou find a very sharp blade on his belt\nYour strength is increased", "Ogre: Finaly! Dinner\nThe Ogre drags you to his lair where he prepares his dinner\nYou are eaten, luckily you bled to death before that happened", "Ogre" };
                    return OgreBarks;
                case 3:
                    string[] ChefBarks = { "An angry Chef appears from the larder, he is brandishing a knife and a rolling pin. He looks mighty angry. \nChef: Get out of here or I'll add you to this succulent Chinese meal!", "Chef: Is that all you've got", "Chef: Haha Take that", "Chef: You have some knife skills...\n You have Defeated the Chef", "Chef: You will go nicely in this dish! \n You have died \n You're on the menu tonight", "Chef" };
                    return ChefBarks;
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
            int[] playerStats = StatsCalculation();
            Console.WriteLine(enemyBarks[0]);
            Console.ReadLine();
            while (playerStats[3] != 0)
            {
                Console.Clear();
                Console.WriteLine("Your Health: " + playerStats[3]);
                Console.WriteLine(enemyBarks[5] + " Health: " + enemyStats[3] + "\n");
                Console.WriteLine("- [1] Attack the " + enemyBarks[5]);
                Console.WriteLine("- [2] Hide from the " + enemyBarks[5]);
                Console.WriteLine("- [3] Talk to the " + enemyBarks[5] + "\n");
                temp1 = Console.ReadLine();
                decision = Convert.ToInt32(temp1);
                Console.Clear();

                if (playerStats[3] == 0)
                {
                    Console.WriteLine(enemyBarks[4]);
                    Console.ReadLine();
                }
                if (enemyStats[3] == 0)
                {
                    Console.WriteLine(enemyBarks[3]);
                    Console.WriteLine("You have defeated your enemy!!");
                    Console.ReadLine();
                    return true;
                }

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
                    Console.Clear();

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
                }
                if (decision == 2)
                {
                    int yourRoll = 0, enemyRoll = 0;
                    Console.WriteLine("You try hide, you use " + playerStats[1] + " dice\n");
                    for (int i = 0; i < playerStats[1]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        yourRoll = yourRoll + dice;
                    }
                    Console.ReadLine();
                    Console.WriteLine("\nThe " + enemyBarks[5] + " checks with " + enemyStats[1] + " dice\n");
                    for (int i = 0; i < enemyStats[1]; i++)
                    {
                        int dice = randy.Next(1, 7);
                        Console.WriteLine(dice);
                        enemyRoll = enemyRoll + dice;
                    }
                    Console.ReadLine();
                    Console.WriteLine("\nYour total stealth roll is " + yourRoll);
                    Console.ReadLine();
                    Console.WriteLine("\nThe " + enemyBarks[5] + "s total stealth is " + enemyRoll);
                    Console.ReadLine();
                    Console.Clear();
                    if (yourRoll > enemyRoll)
                    {
                        Console.WriteLine("\nYou hide from the " + enemyBarks[5] + "\n");
                        Console.WriteLine(enemyBarks[5] + ": where did you go?");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Your options are...");
                        Console.WriteLine("- [1] Run from the " + enemyBarks[5]);
                        Console.WriteLine("- [2] Backstab the " + enemyBarks[5]);
                        temp1 = Console.ReadLine();
                        decision = Convert.ToInt32(temp1);
                        Console.Clear();

                        if (decision == 1)
                        {
                            Console.WriteLine("You escape the " + placeName);
                            Console.ReadLine();
                            return false;
                        }
                        if (decision == 2)
                        {
                            Console.WriteLine("You try backstab the " + enemyBarks[5] + ", you use " + playerStats[1] + " dice\n");
                            for (int i = 0; i < playerStats[1]; i++)
                            {
                                int dice = randy.Next(1, 7);
                                Console.WriteLine(dice);
                                yourRoll = yourRoll + dice;
                            }
                            Console.ReadLine();
                            Console.WriteLine("\nThe " + enemyBarks[5] + " checks with " + enemyStats[1] + " dice\n");
                            for (int i = 0; i < enemyStats[1]; i++)
                            {
                                int dice = randy.Next(1, 7);
                                Console.WriteLine(dice);
                                enemyRoll = enemyRoll + dice;
                            }
                            Console.ReadLine();
                            Console.WriteLine("\nYour total stealth roll is " + yourRoll);
                            Console.ReadLine();
                            Console.WriteLine("\nThe " + enemyBarks[5] + "s total stealth is " + enemyRoll);
                            Console.ReadLine();
                            Console.Clear();

                            if (yourRoll > enemyRoll)
                            {
                                Console.WriteLine("You backstab the " + enemyBarks[5]);
                                enemyStats[3] = enemyStats[3] - 2;
                                Console.WriteLine(enemyBarks[1]);
                                Console.ReadLine();
                                Console.Clear();
                            }
                            if (yourRoll < enemyRoll)
                            {
                                Console.WriteLine("The " + enemyBarks[5] + " sees you coming and hits you");
                                playerStats[3] = playerStats[3] - 1;
                                Console.WriteLine(enemyBarks[2]);
                                Console.ReadLine();
                                Console.Clear();
                            }
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
                    bool Knowing = false;
                    if (Knowing == false)
                    {
                        Console.WriteLine("You attempt to talk to the " + enemyBarks[5]);
                        Console.WriteLine("- [1] Seduce");
                        Console.WriteLine("- [2] Intimedate");
                        Console.WriteLine("- [3] Persuade");
                        Console.WriteLine("- [4] Trick");
                        temp1 = Console.ReadLine();
                        decision = Convert.ToInt32(temp1);
                        if (decision == 1)
                        {
                            Console.WriteLine("You try seducing the " + enemyBarks[5]);
                            Console.ReadLine();
                            Console.Clear();

                            int yourRoll = 0, enemyRoll = 0;
                            Console.WriteLine("You seduce with " + playerStats[0] + " dice");
                            Console.ReadLine();
                            for (int i = 0; i < playerStats[2]; i++)
                            {
                                int dice = randy.Next(1, 7);
                                Console.WriteLine(dice);
                                yourRoll = yourRoll + dice;
                            }
                            Console.ReadLine();
                            Console.WriteLine("\nThe " + enemyBarks[5] + " checks with " + enemyStats[0] + " dice");
                            Console.ReadLine();
                            for (int i = 0; i < enemyStats[2]; i++)
                            {
                                int dice = randy.Next(1, 7);
                                Console.WriteLine(dice);
                                enemyRoll = enemyRoll + dice;
                            }
                            Console.ReadLine();
                            Console.WriteLine("\nYour total cunning roll is " + yourRoll);
                            Console.ReadLine();
                            Console.WriteLine("\nThe " + enemyBarks[5] + "s total check roll is " + enemyRoll);
                            Console.ReadLine();
                            Console.Clear();

                            if (yourRoll > enemyRoll)
                            {
                                Console.WriteLine("You succsefully seduce the " + enemyBarks[5] + " and you after a while, the " + enemyBarks[5] + " is fast asleep on the floor");
                                Console.ReadLine();
                                return true;
                            }
                            if (yourRoll < enemyRoll)
                            {
                                Console.WriteLine("The " + enemyBarks[5] + " catchs on");
                                Console.ReadLine();
                                Console.Clear();
                                Knowing = true;
                                playerStats[3] = playerStats[3] - 1; 
                            }
                            if (decision == 2)
                            {
                                Console.WriteLine("You try Intimidating the " + enemyBarks[5]);
                                Console.ReadLine();
                                Console.Clear();

                                Console.WriteLine("You intimidate with " + playerStats[0] + " dice");
                                Console.ReadLine();
                                for (int i = 0; i < playerStats[2]; i++)
                                {
                                    int dice = randy.Next(1, 7);
                                    Console.WriteLine(dice);
                                    yourRoll = yourRoll + dice;
                                }
                                Console.ReadLine();
                                Console.WriteLine("\nThe " + enemyBarks[5] + " checks with " + enemyStats[0] + " dice");
                                Console.ReadLine();
                                for (int i = 0; i < enemyStats[2] + 1; i++)
                                {
                                    int dice = randy.Next(1, 7);
                                    Console.WriteLine(dice);
                                    enemyRoll = enemyRoll + dice;
                                }
                                Console.ReadLine();
                                Console.WriteLine("\nYour total cunning roll is " + yourRoll);
                                Console.ReadLine();
                                Console.WriteLine("\nThe " + enemyBarks[5] + "s total check roll is " + enemyRoll);
                                Console.ReadLine();
                                Console.Clear();

                                if (yourRoll > enemyRoll)
                                {
                                    Console.WriteLine("You succsefully intimidate the " + enemyBarks[5] + ", he promises not to bother you anymore and runs away");
                                    Console.ReadLine();
                                    return true;
                                }
                                if (yourRoll < enemyRoll)
                                {
                                    Console.WriteLine("The " + enemyBarks[5] + " scofs at you attempt to intimidate and hits you");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Knowing = true;
                                    playerStats[3] = playerStats[3] - 1;
                                }
                            }
                            if (decision == 3)
                            {
                                Console.WriteLine("You try persuading the " + enemyBarks[5]);
                                Console.ReadLine();
                                Console.Clear();

                                Console.WriteLine("You persuade with " + playerStats[0] + " dice");
                                Console.ReadLine();
                                for (int i = 0; i < playerStats[2]; i++)
                                {
                                    int dice = randy.Next(1, 7);
                                    Console.WriteLine(dice);
                                    yourRoll = yourRoll + dice;
                                }
                                Console.ReadLine();
                                Console.WriteLine("\nThe " + enemyBarks[5] + " checks with " + enemyStats[0] + " dice");
                                Console.ReadLine();
                                for (int i = 0; i < enemyStats[2] + 1; i++)
                                {
                                    int dice = randy.Next(1, 7);
                                    Console.WriteLine(dice);
                                    enemyRoll = enemyRoll + dice;
                                }
                                Console.ReadLine();
                                Console.WriteLine("\nYour total cunning roll is " + yourRoll);
                                Console.ReadLine();
                                Console.WriteLine("\nThe " + enemyBarks[5] + "s total check roll is " + enemyRoll);
                                Console.ReadLine();
                                Console.Clear();

                                if (yourRoll > enemyRoll)
                                {
                                    Console.WriteLine("You succsefully persuade the " + enemyBarks[5] + ",you him just to let you do whatever");
                                    Console.ReadLine();
                                    return true;
                                }
                                if (yourRoll < enemyRoll)
                                {
                                    Console.WriteLine("The " + enemyBarks[5] + " is not persuaded and hits you");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Knowing = true;
                                    playerStats[3] = playerStats[3] - 1;
                                }
                            }
                            if (decision == 4)
                            {
                                Console.WriteLine("You try tricking the " + enemyBarks[5]);
                                Console.ReadLine();
                                Console.Clear();

                                Console.WriteLine("You trick with " + playerStats[0] + " dice");
                                Console.ReadLine();
                                for (int i = 0; i < playerStats[2]; i++)
                                {
                                    int dice = randy.Next(1, 7);
                                    Console.WriteLine(dice);
                                    yourRoll = yourRoll + dice;
                                }
                                Console.ReadLine();
                                Console.WriteLine("\nThe " + enemyBarks[5] + " checks with " + enemyStats[0] + " dice");
                                Console.ReadLine();
                                for (int i = 0; i < enemyStats[2] + 1; i++)
                                {
                                    int dice = randy.Next(1, 7);
                                    Console.WriteLine(dice);
                                    enemyRoll = enemyRoll + dice;
                                }
                                Console.ReadLine();
                                Console.WriteLine("\nYour total cunning roll is " + yourRoll);
                                Console.ReadLine();
                                Console.WriteLine("\nThe " + enemyBarks[5] + "s total check roll is " + enemyRoll);
                                Console.ReadLine();
                                Console.Clear();

                                if (yourRoll > enemyRoll)
                                {
                                    Console.WriteLine("You succsefully trick the " + enemyBarks[5] + ", and the " + enemyBarks[5] + " leaves");
                                    Console.ReadLine();
                                    return true;
                                }
                                if (yourRoll < enemyRoll)
                                {
                                    Console.WriteLine("The " + enemyBarks[5] + " is not persuaded and hits you");
                                    Console.ReadLine();
                                    Console.Clear();
                                    Knowing = true;
                                    playerStats[3] = playerStats[3] - 1;
                                }
                            }
                        }
                    }
                    
                    Console.Clear();
                }
            }
            Console.Clear();
            GameOver();
            return false;
           
        }




        public static void Inventory()
        {
            int[] Stats = StatsCalculation();
            string[] ClothingInfo = clothingString(Clothing);
            String[] WeaponInfo = weaponString(Weapon);
            String[] ItemInfo = otherItemsString(Item);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("~Inventory~");
            Console.WriteLine("-----------");
            Console.WriteLine($"  Weapon    : {WeaponInfo[0]}");
            Console.WriteLine($"  Cloathing : {ClothingInfo[0]}");
            Console.WriteLine($"  Accesories: {ItemInfo[0]}");
            Console.WriteLine($"  Key       : {keySlot}");
            Console.WriteLine();
            Console.WriteLine("~Statistics~");
            Console.WriteLine("------------");
            Console.WriteLine($"  Strength : {Stats[0]}");
            Console.WriteLine($"  Stealth  : {Stats[1]}");
            Console.WriteLine($"  Cunning  : {Stats[2]}");
            Console.WriteLine($"  Health   : {Stats[3]}");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Your options are...");
                Console.WriteLine("- [1] Go Investigate the Hallway");
                Console.WriteLine("- [2] Stay Imprisoned");
                Console.WriteLine("- [3] Check Inventory");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();

                temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp))
                {
                    Console.Clear();
                    Console.WriteLine("Please Enter a valid input...");
                    Console.ReadLine();
                    Console.Clear();
                    Dungeon();
                }
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You have entered an invalid input");
                        Console.WriteLine("Press any key to continue...");
                        Console.ForegroundColor = ConsoleColor.Red;
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                NorthMiddleHallway();
            }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                LeftHallway();
            }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                RightHallway();
            }
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
                    if ((LockedmysteryroomButton == false) && (keySlot == "~Door Key~"))
                    {

                        do
                        {
                            Console.WriteLine("The door is locked. Use the key? y/n ");
                            temp = Console.ReadLine();
                            if (temp == "y")
                            {
                                LockedmysteryroomButton = true;
                                keySlot = "...";
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
                        } while ((temp != "y") || (temp != "n"));

                    }
                    if (LockedmysteryroomButton == true)
                    {
                        Lockedmysteryroom();
                    }
                    else
                    {
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }
        public static void Crematorium()/*one item Lucky ring +1 to cunning*/
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                Crematorium();
            }
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    LeftHallway();
                    break;
                case 2:
                    Console.WriteLine("You find a large pile of ashes in the oven and you notice your deceased father's lucky ring.");
                    Console.WriteLine("Would you like to take your father's ring? y/n");
                    temp = Console.ReadLine();
                    if (temp == "y")
                    {
                        Item = 1;
                        String[] ItemInfo = otherItemsString(Item);
                        Console.WriteLine($"{ItemInfo[0]} \n{ItemInfo[1]} \n{ItemInfo[2]}");

                        for (int i = 0; i < stats.Length; i++)
                        {
                            stats[i] = stats[i] + other_Items(Item)[i];
                        }

                        EmptyArmouryButton = true;
                        Console.ReadLine();
                        CrematoriumB();
                        break;
                    }
                    else
                    {
                        Crematorium();

                    }
                    break;


                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Crematorium();
                    break;

                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }

        public static void CrematoriumB()
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                CrematoriumB();
            }
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    LeftHallway();
                    break;
                case 2:
                    Console.WriteLine("You find a large pile of ashes in the oven, there is nothing here put scorched remains.");
                    Console.WriteLine("PRESS ENTER to exit the oven");
                    Console.ReadLine();
                    CrematoriumB();
                    break;


                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    CrematoriumB();
                    break;

                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
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
            Console.WriteLine("- [2] Try to get the key!");
            Console.WriteLine("- [3] Check Inventory");
            Console.WriteLine();
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                GuardsChamber();
            }
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

                    bool result = Battle(Scenario, PlaceName);
                    if (result == true)
                    {
                        keySlot = "~Door Key~";
                        Console.WriteLine($"You picked up {keySlot}");
                        Console.WriteLine($"It could be usefull somewhere...");
                        Clothing = 3;
                        String[] clothingInfo = clothingString(Clothing);
                        Console.WriteLine($"{clothingInfo[0]} \n{clothingInfo[1]} \n{clothingInfo[2]}");

                        for (int i = 0; i < stats.Length; i++)
                        {
                            stats[i] = stats[i] + clothing(Clothing)[i];
                        }
                        GuardsChamberButton = true;
                        Console.ReadLine();
                    }

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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                GuardsChamberB();
            }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
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
            Console.WriteLine("You are in a large dark room with a cage containing the BEAST...\nTo your left there is a key to unlock his cage\nTo the right there is a basket full of meat\n");
            Thread.Sleep(1000);
            Console.WriteLine("There is a low risk of surviving if you let it free but you could try taming it...\n");
            Thread.Sleep(1000);
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Leave the BEAST alone and leave the lair");
            Console.WriteLine("- [2] Use the cage key to free it");
            Console.WriteLine("- [3] Grab a piece of chicken and feed the BEAST");
            Console.WriteLine("- [4] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                Lairofthebeast();
            }
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    RightHallway();
                    break;
                case 2:
                    Console.WriteLine("The BEAST grabs you, throws you out of the lair causing a loss in your health\n");
                    Console.WriteLine("Your [Health] - (1)");
                    health = health - 1;
                    Console.ReadKey();
                    RightHallway();
                    break;
                case 3:
                    Console.WriteLine("You reach inside the basket grab a juicy thigh piece and throw it to the hungry BEAST...");
                    Thread.Sleep(1000);
                    Console.WriteLine("He grabs it, swallows it whole and is hungry for some more...\n");
                    Console.WriteLine("Press Any Key To Continue");
                    Console.ReadKey();
                    Lairofthebeast();
                    break;
                case 4:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Lairofthebeast();
                    break;

                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadKey();
                    break;
            }
        }
        public static void Lockedmysteryroom()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Mystery Room");
            Console.WriteLine("There is a stairwell in the middle ");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] Go up the stairwell to the Second Floor");
            Console.WriteLine("- [3] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                Lockedmysteryroom();
            }
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    RightHallway();
                    break;
                case 2:
                    Secondfloor_greathall();
                    break;
                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Lockedmysteryroom();
                    break;

                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                Southeasthallway();
            }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                EmptyArmoury();
            }
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    Southeasthallway();
                    break;
                case 2:

                    Weapon = 1;
                    String[] WeaponInfo = weaponString(Weapon);
                    Console.WriteLine($"{WeaponInfo[0]} \n{WeaponInfo[1]} \n{WeaponInfo[2]}");

                    for (int i = 0; i < stats.Length; i++)
                    {
                        stats[i] = stats[i] + weapon(ref Weapon)[i];
                    }

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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                EmptyArmouryB();
            }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                Southwesthallway();
            }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }
        public static void Heavydungeon()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Prison");
            Console.WriteLine("A big number of miserables are imprisoned here begging for help. Probably victims of King's unfair tirany. ");
            Console.WriteLine("The same king that ordered your detention here. Your feelings for revenge are rising.  ");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                Heavydungeon();
            }
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    Southwesthallway();
                    break;

                case 2:
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
        {
            string temp;
            int input;
            Console.Clear();
            Console.WriteLine("You are in the Better Armory");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards"); 
            Console.WriteLine("- [2] Check the Chest ");
            Console.WriteLine("- [3] option3"); // CHECK CHEST?
            Console.WriteLine("- [4] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                BetterArmory();
            }
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
                    Secondfloor_greathallB();
                    break;

                case 2:
                    Weapon = 2;
                    String[] WeaponInfo = weaponString(Weapon);
                    Console.WriteLine($"{WeaponInfo[0]} \n{WeaponInfo[1]} \n{WeaponInfo[2]}");
                    for (int i=0; i < stats.Length; i++)
                    {
                        stats[i] = stats[i] + weapon(ref Weapon)[i];
                    }
                    BetterArmoryButton = true;
                    Console.ReadLine();
                    BetterArmoryB();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }

        public static void BetterArmoryB()

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
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                BetterArmoryB();
            }
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }
        public static void Secondfloor_greathall()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Great Hall ");
            Console.WriteLine("To your left you see a very fancy door, next to it, a horrendous creature sleeps unaware of your presence.");
            Console.WriteLine("It seems to be one of those ogres you heard about in the old stories.");
            Console.WriteLine("To your right there is a big gate which looks like the way to your freedom.");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go down the staircase");
            Console.WriteLine("- [2] Go towards the gate");
            Console.WriteLine("- [3] Go towards the fancy door");
            Console.WriteLine("- [4] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                Secondfloor_greathall();
            }
            input = Convert.ToInt32(temp);
            Console.Clear();

            int Scenario = 2;
            string PlaceName = "Great Hall";

            switch (input)
            {
                case 1:
                    Lockedmysteryroom();
                    break;
                case 2:
                    if ((GreatHallButton == false) && (keySlot == "~Gate Key~"))
                    {

                        do
                        {
                            Console.WriteLine("The door is locked. Use the key? y/n ");
                            temp = Console.ReadLine();
                            if (temp == "y")
                            {
                                LockedmysteryroomButton = true;
                                keySlot = "Empty";
                                //Outside();

                            }
                            else if (temp == "n")
                            {
                                Secondfloor_greathall();
                            }
                            else
                            {
                                Console.WriteLine("Wrong command");
                            }
                        } while ((temp != "y") || (temp != "n"));
                    }
                    else
                    {
                        Console.WriteLine("You try to open desperately but the gate is locked. ");
                        Console.WriteLine("It seems you will need to look for the key to open it...");
                        Console.ReadLine();
                        Secondfloor_greathall();

                    }
                    break;
                case 3:
                    bool result = Battle(Scenario, PlaceName);
                    if (result == true)
                    {
                        keySlot = "~Gate Key~";
                        Console.WriteLine($"You picked up {keySlot}");
                        Console.WriteLine($"It migth take you out of here...");
                        GreatHallButton = true;
                        Console.ReadLine();
                        Secondfloor_greathallB();
                    }
                    break;
                case 4:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Secondfloor_greathall();
                    break;

                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }
        public static void Secondfloor_greathallB()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Great Hall ");
            Console.WriteLine("To your left you see a very fancy door, next to it, a horrendous creature sleeps unaware of your presence.");
            Console.WriteLine("It seems to be one of those ogres you heard about in the old stories.");
            Console.WriteLine("To your right there is a big gate which looks like the way to your freedom.");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go down the staircase");
            Console.WriteLine("- [2] Go towards the gate");
            Console.WriteLine("- [3] Enter the fancy door");
            Console.WriteLine("- [4] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.Clear();
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Console.Clear();
                Secondfloor_greathallB();
            }
            input = Convert.ToInt32(temp);
            Console.Clear();

         

            switch (input)
            {
                case 1:
                    Lockedmysteryroom();
                    break;
                case 2:
                    if ((GreatHallButton == false) && (keySlot == "~Gate Key~"))
                    {

                        do
                        {
                            Console.WriteLine("The door is locked. Use the key? y/n ");
                            temp = Console.ReadLine();
                            if (temp == "y")
                            {
                                LockedmysteryroomButton = true;
                                keySlot = "Empty";
                                //Outside();

                            }
                            else if (temp == "n")
                            {
                                Secondfloor_greathall();
                            }
                            else
                            {
                                Console.WriteLine("Wrong command");
                            }
                        } while ((temp != "y") || (temp != "n"));
                    }
                    else
                    {
                        Console.WriteLine("You try to open desperately but the gate is locked. ");
                        Console.WriteLine("It seems you will need to look for the key to open it...");
                        Console.ReadLine();
                        Secondfloor_greathall();

                    }
                    break;

                case 3:
                    BetterArmory();
                    break;

                case 4:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Secondfloor_greathall();
                    break;

                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }
        public static void Chapel()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Chapel ");
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
                    //();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }
        public static void Treasureroom()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Treasure Room ");
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
                    //();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }
        public static void Soldiersquarters()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Soldiers Quarters ");
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
                    // ();
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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }
        public static void Kitchen()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Castle's Kitchen ");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");

            Console.WriteLine("- [3] Check Inventory");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            int Scenario = 3;
            string PlaceName = "Kitchen";

            switch (input)
            {
                case 1:
                    //();
                    break;
                case 2:
                bool result = Battle(Scenario, PlaceName);

                    break;
                //     break;
                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    Heavydungeon();
                    break;

                default:
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have entered an invalid input");
                    Console.WriteLine("Press any key to continue...");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.ReadLine();
                    break;
            }
        }
        public static void Introduction()
        {
            Console.WriteLine("                                                                  ");
            Console.WriteLine("                                                                  ");
            Console.WriteLine("      ██████████  █████████  ████████   ████████   ██      ██     ");
            Console.WriteLine("          ██      ██         ██     ██  ██     ██   ██    ██      ");
            Console.WriteLine("          ██      ██         ██     ██  ██     ██    ██  ██       ");
            Console.WriteLine("          ██      █████      ████████   ████████      ████        ");
            Console.WriteLine("          ██      ██         ██   ██    ██   ██        ██         ");
            Console.WriteLine("          ██      ██         ██    ██   ██    ██       ██         ");
            Console.WriteLine("          ██      ██         ██     ██  ██     ██      ██         ");
            Console.WriteLine("          ██      █████████  ██     ██  ██     ██      ██         ");
            Console.WriteLine("                                                                  ");
            Console.WriteLine("                                                                  ");
            Console.WriteLine("  The Adventure Game By:                                          ");
            Console.WriteLine("                                                                  ");
            Console.WriteLine("  Miguel, Mace, Te Awa, Lewis and Francis                         ");
            Console.WriteLine("                                                                  ");
            Console.WriteLine("  ©2021                                                           ");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine(@"                                                                          ");
            Console.WriteLine(@"                                                                          ");
            Console.WriteLine(@"            o                                                             ");
            Console.WriteLine(@"           <|                                                             ");
            Console.WriteLine(@"            |                                                             ");
            Console.WriteLine(@"           / \                                                            ");
            Console.WriteLine(@"          /   \                                                           ");
            Console.WriteLine(@"         /     \            o                o          //\\              ");
            Console.WriteLine(@"        /_______\          <|               <|         //^^\\             ");
            Console.WriteLine(@"       (_|_|_|_|_)          |                |        //^^^^\\            ");
            Console.WriteLine(@"       |         |         /^\              /^\      //^^^^^^\\           ");
            Console.WriteLine(@"       |[|][|][|]|        /^^^\            /^^^\    //^^^^^^^^\\          ");
            Console.WriteLine(@"      _|_________|_      /^^^^^\          /^^^^^\  //__________\\         ");
            Console.WriteLine(@"      |           |     (_|_|_|_)        (_|_|_|_)  | /^\  /^\ |          ");
            Console.WriteLine(@"       \_\_|_|_/_/       |     |IIIIIIIIII|     |   | |*|  |*| |          ");
            Console.WriteLine(@"        |       |        |  []               [] | __|_ ___ ___ |_         ");
            Console.WriteLine(@"        |   I   |        |         + + +        | |-|_|-|_|-|_|-|         ");
            Console.WriteLine(@"        |       |        |  []      |_|      [] |  \           /          ");
            Console.WriteLine(@"        |   I   |________|______________________|__|     II    |          ");
            Console.WriteLine(@"        |        |_|-|_|-|_|-|_|-|_|-|_|-|_|-|_|-|_|           |          ");
            Console.WriteLine(@"        |                                                      |          ");
            Console.WriteLine(@"       /    +      +      +    //////\\\\\\     +     +   II    \         ");
            Console.WriteLine(@"      |                        |          |                      |         ");
            Console.WriteLine(@"      |                        |          |                      |         ");
            Console.WriteLine(@"      |........................|          |......................|         ");
            Console.WriteLine("                                                                           ");
            Console.WriteLine("                          PLEASE PRESS ENTER TO PLAY                       ");
            Console.WriteLine("                                                                           ");
            Console.WriteLine("                                                                           ");
            Console.ReadLine();

            Console.WriteLine("Terry is an orphan fruit merchant in the town of Studiojuan, he spends his days selling fruit");
            Console.WriteLine("and minding his own business at his fruit stall in the town square. Terry dislikes trouble and");
            Console.WriteLine("avoids confrontation at every turn. Trouble is what got his parents killed.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("It is just another boring saturday morning in StudioJuan and Terry is sitting in his fruit stall");
            Console.WriteLine("minding his own business. 'What a lovely day' he says to himself as he spit shines the last few");
            Console.WriteLine("remaining apples from the morning rush. A woman approches his stall through the thinning crowd,");
            Console.WriteLine("she is dressed fancily and is wearing a vail that is covering her face. 'Nice day for an apple");
            Console.WriteLine("is it not?' she asks Terry. 'Yes maddam' replied terry.");
            Console.WriteLine();
            Console.WriteLine("Suddenly Terry is hit on the head and he falls to the ground.");
        }
        public static void Main()
        {
            int Character;

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Choose a character: ");
                Console.WriteLine("Select: 1 for Strength, 2 for Stealth or 3 for Cunning.");
                Console.WriteLine();
                Console.WriteLine("       1 - Strength       2 - Stealth        3 - Cunning");
                Console.WriteLine("          ----------         ---------          ---------");
                Console.WriteLine("Strength:     3                  1                  1     ");
                Console.WriteLine("Stealth :     1                  4                  1     ");
                Console.WriteLine("Cunning :     1                  2                  4     ");
                Console.WriteLine("Health  :     4                  2                  3     ");

                Clothing = 1;

                Console.ForegroundColor = ConsoleColor.Yellow;



                temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp))
                {
                    Console.Clear();
                    Console.WriteLine("Please Enter a valid input...");
                    Console.ReadLine();
                    Console.Clear();
                    Main();
                }
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
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong command. ");
                        Console.WriteLine("PRESS ENTER");
                        Console.ForegroundColor = ConsoleColor.Red;
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