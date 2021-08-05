using Command_Line_Adventure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Terry_demo
{
    public class Bloodcage
    {
        public struct Items
        {
            public int Item1;
            public string Iname1;
            public int Item2;
            public string Iname2;
            public int Item3;
            public string Iname3;
            public int Item4;
            public string Iname4;
        }
        public struct Inventory
        {
            public int[] Weapon;
            public string[] Wname;
            public int[] Clothing;
            public string[] Cname;
            public int Coins;
            public Items items;
        }

        public Program program;
        public int[] Playerstats;
        public Inventory inventory;
        public int choice;
        public string temp;

        public bool StealKnife;
        public bool KnightDeal;

        public bool LeftPathBattle;
        public int BrokenHallState;

        public void Backpack(int X, int S)
        {
            int IntMod = 0;
            string String = "";

            switch (X)
            {
                case 0:
                    IntMod = 1;
                    String = "~Bandage~ <> Good for keeping you alive";
                    break;
                default:
                    IntMod = 0;
                    String = "~empty~";
                    break;
                    
            }
            switch (S)
            {
                case 1:
                    inventory.items.Item1 = IntMod;
                    inventory.items.Iname1 = String;
                    break;
                case 2:
                    inventory.items.Item2 = IntMod;
                    inventory.items.Iname2 = String;
                    break;
                case 3:
                    inventory.items.Item3 = IntMod;
                    inventory.items.Iname3 = String;
                    break;
                case 4:
                    inventory.items.Item4 = IntMod;
                    inventory.items.Iname4 = String;
                    break;
            }
        }

        public void YourStuff(Inventory inventory)
        {
            int[] weaponStats = inventory.Weapon;

            int[] clothingStats = inventory.Clothing;

            for (int i = 0; i < 4; i++)
            {
                Playerstats[i] = Playerstats[i] + weaponStats[i] + clothingStats[i];
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine();
            Console.WriteLine("~Inventory~");
            Console.WriteLine("-----------");
            Console.WriteLine($"  Weapon    : {inventory.Wname[0]} <> {inventory.Wname[1]}");
            Console.WriteLine($"  Cloathing : {inventory.Cname[0]} <> {inventory.Cname[1]}");
            Console.WriteLine($"  Item 1    : {inventory.items.Iname1}");
            Console.WriteLine($"  Item 2    : {inventory.items.Iname2}");
            Console.WriteLine($"  Item 3    : {inventory.items.Iname3}");
            Console.WriteLine($"  Item 4    : {inventory.items.Iname4}");
            Console.WriteLine();
            Console.WriteLine("~Statistics~");
            Console.WriteLine("------------");
            Console.WriteLine($"  Strength : {Playerstats[0]}");
            Console.WriteLine($"  Stealth  : {Playerstats[1]}");
            Console.WriteLine($"  Cunning  : {Playerstats[2]}");
            Console.WriteLine($"  Health   : {Playerstats[3]}");
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue...");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ReadLine();
        }

        public void Wake()
        {
            Console.Clear();
            Console.WriteLine("You fall asleep, waking up to a looked door. Many days pass, only barely suviving on the scraps they gave you");
            Console.WriteLine("Guard : You! get up, its your turn in the BloodCage\n");
            Console.WriteLine("The guard chains you up and drags you down the hall, then throws you into the Ruins");
            Console.WriteLine("Guard : Id say good luck but even thats not gonna help you\n");
            Console.WriteLine("A metal gate drops in between you both and he walks away luaghing to himself\n");
            Console.WriteLine("[1] Move into the scary Ruins");
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
                Wake();
            }
            choice = Convert.ToInt32(temp);
            switch (choice)
            {
                case 1:
                    Ruins();
                    break;
                default:
                    break;
            }
        }

        public void Ruins()
        {
            choice = 0;
            Console.Clear();
            Console.WriteLine("You enter the ruins, ruble and broken podiums litter the room");
            Console.WriteLine("There are two paths, one on the left and one on the right\n");
            Console.WriteLine("[1] Move to Left path");
            Console.WriteLine("[2] Move to right path");
            Console.WriteLine("[3] Check Inventory");
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
            }
            choice = Convert.ToInt32(temp);
            switch (choice)
            {
                case 1:
                    LeftPath();
                    break;
                case 2:
                    RightPath();
                    break;
                case 3:
                    YourStuff(inventory);
                    Ruins();
                    break;
                default:
                    break;
            }
        }

        public void LeftPath()
        {
            choice = 0;
            if (LeftPathBattle == false)
            {
                Console.Clear();
                Console.WriteLine("You see a scared man muttering to himself in this empty room");
                Console.WriteLine("He does not seem to notice you\n");
                Console.WriteLine("[1] Ask 'Whats going on here?'");
                Console.WriteLine("[2] Attack him");
                Console.WriteLine("[3] Sneak up to him");
                Console.WriteLine("[4] Leave");
                Console.WriteLine("[5] Check Inventory");
                temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Please Enter a valid input...");
                    Console.ReadLine();
                }
                choice = Convert.ToInt32(temp);
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Scared man : 'we are all gonna die, its coming for us'\n");
                        Console.WriteLine("[1] Ask 'Whats coming for us?'");
                        Console.WriteLine("[2] Leave him alone");
                        if (Playerstats[2] >= 3)
                        {
                            Console.WriteLine("[3] Ask 'Whats that in your bag?'");
                        }
                        temp = Console.ReadLine();
                        if (string.IsNullOrEmpty(temp))
                        {
                            Console.WriteLine("Please Enter a valid input...");
                            Console.ReadLine();
                        }
                        choice = Convert.ToInt32(temp);
                        switch (choice)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("Scared man : 'The Beast is coming for us! leave me alone or it might find us'");
                                Console.ReadLine();
                                LeftPath();
                                break;
                            case 2:
                                LeftPath();
                                break;
                            case 3:
                                if (Playerstats[2] >= 3)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Scared man : 'What this? here you can have it, no way in hell im going to fight that thing'");
                                    Console.ReadLine();
                                    Console.WriteLine("New Weapon ~Knife~");
                                    Console.ReadLine();
                                    inventory.Weapon = Program.weapon(3);
                                    inventory.Wname = Program.weaponString(3);
                                }
                                break;
                        }
                        break;
                    case 2:
                        Program.Battle(6, "Empty Ruin");
                        Console.WriteLine("You defeated the Prisoner\nYou see hes got a Knife and a few coins\n");
                        Console.WriteLine("[1] Take his Knife and coins");
                        Console.WriteLine("[2] Leave");
                        temp = Console.ReadLine();
                        if (string.IsNullOrEmpty(temp))
                        {
                            Console.WriteLine("Please Enter a valid input...");
                            Console.ReadLine();
                        }
                        choice = Convert.ToInt32(temp);
                        if (choice == 1)
                        {
                            Console.WriteLine("New Weapon ~Knife~");
                            inventory.Weapon = Program.weapon(3);
                            inventory.Wname = Program.weaponString(3);
                            inventory.Coins = inventory.Coins + 2;

                            Console.ReadLine();
                        }
                        LeftPathBattle = true;
                        break;
                    case 3:
                        int yourRoll = 0, enemyRoll = 0;
                        Random randy = new Random();
                        string[] enemyBarks = Program.EnemyBarks(6);
                        int[] enemyStats = Program.EnemyStats(6);
                        Console.WriteLine("You sneak with " + Playerstats[1] + " dice");
                        Console.ReadLine();
                        for (int i = 0; i < Playerstats[1]; i++)
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
                        Console.WriteLine("Your total sneak is " + yourRoll);
                        Console.WriteLine("The " + enemyBarks[5] + "s total check is " + enemyRoll);
                        Console.ReadLine();
                        Console.Clear();

                        if (yourRoll > enemyRoll)
                        {
                            if (StealKnife == false)
                            {
                                Console.WriteLine("You can see a Knife in his bag and a few coins, he still hasent noticed you\n");
                                Console.WriteLine("[1] Steal the Knife");
                                Console.WriteLine("[2] Sneak Back");

                                temp = Console.ReadLine();
                                if (string.IsNullOrEmpty(temp))
                                {
                                    Console.WriteLine("Please Enter a valid input...");
                                    Console.ReadLine();
                                }
                                choice = Convert.ToInt32(temp);

                                switch (choice)
                                {
                                    case 1:
                                        Console.WriteLine("New Weapon ~Knife~");
                                        inventory.Weapon = Program.weapon(3);
                                        inventory.Wname = Program.weaponString(3);
                                        inventory.Coins = inventory.Coins + 2;

                                        StealKnife = true;

                                        Console.ReadLine();
                                        break;
                                    case 2:
                                        LeftPath();
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("You cant see anything else on him\n");
                                Console.WriteLine("[1] Sneak Back");

                                temp = Console.ReadLine();
                                if (string.IsNullOrEmpty(temp))
                                {
                                    Console.WriteLine("Please Enter a valid input...");
                                    Console.ReadLine();
                                }
                                choice = Convert.ToInt32(temp);

                                switch (choice)
                                {
                                    case 1:
                                        LeftPath();
                                        break;
                                }
                            }
                            
                        }
                        if (yourRoll < enemyRoll)
                        {
                            Console.WriteLine("Scared man : 'Huh?! Stay BACK!'\n");
                            Program.Battle(6, "Empty Ruin");
                            Console.WriteLine("You killed the Prisoner\nYou see hes got a Knife\n");
                            Console.WriteLine("[1] Take his Knife");
                            Console.WriteLine("[2] Leave");

                            LeftPathBattle = true;

                            temp = Console.ReadLine();
                            if (string.IsNullOrEmpty(temp))
                            {
                                Console.WriteLine("Please Enter a valid input...");
                                Console.ReadLine();
                            }
                            choice = Convert.ToInt32(temp);
                            if (choice == 1)
                            {
                                Console.WriteLine("New Weapon ~Knife~");
                                inventory.Weapon = Program.weapon(3);
                                inventory.Wname = Program.weaponString(3);
                                inventory.Coins = inventory.Coins + 2;

                                Console.ReadLine();
                            }
                            else
                            {
                                Ruins();
                            }                           
                        }
                        break;
                    case 4:
                        Ruins();
                        break;
                    case 5:
                        YourStuff(inventory);
                        LeftPath();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You see the Prisoners corpse on the ground\n");
                Console.WriteLine("[1] Leave");
                Console.WriteLine("[2] Cheack Inventoery");
                temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Please Enter a valid input...");
                    Console.ReadLine();
                }
                choice = Convert.ToInt32(temp);
                switch (choice)
                {
                    case 1:
                        Ruins();
                        break;
                    case 2:
                        YourStuff(inventory);
                        break;
                    default:
                        break;
                }
            }
        LeftPath();
        }

        public void RightPath()
        {
            choice = 0;
            Console.Clear();
            Console.WriteLine("You enter a dark hallway, you see a light at the end of the hallway\n");
            Console.WriteLine("[1] Follow the light");
            Console.WriteLine("[2] Go back");
            Console.WriteLine("[3] Check Inventory");
            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
            }
            choice = Convert.ToInt32(temp);
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("You get attacked by something from behind");
                    Program.Battle(5, "Dark Hallway");
                    Console.WriteLine("You slay the Gaint rat");
                    BrokenHall();
                    break;
                case 2:
                    Ruins();
                    break;
                case 3:
                    YourStuff(inventory);
                    break;
                default:
                    break;

            }
        }

        public void BrokenHall()
        {
            if (BrokenHallState == 0)
            {
                choice = 0;
                Console.Clear();
                Console.WriteLine("You enter an old hall, with a long table in the middile, the walls are decorated with tattered royal banners");
                Console.WriteLine("Resting on a pile of rubble a Knight sits holding his leg");
                Console.WriteLine("[1] Ask 'Who are you?'");
                Console.WriteLine("[2] Attack");
                Console.WriteLine("[3] Sneak");
                Console.WriteLine("[4] Leave");
                Console.WriteLine("[5] Check Inventory");

                temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Please Enter a valid input...");
                    Console.ReadLine();
                }
                choice = Convert.ToInt32(temp);

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Sir David : 'I am Sir David, and Im stuck down her for good if you dont help me'");
                        Console.WriteLine("Sir David : 'If you fetch my bag I left down in the Celler I can asure you both our freedom\n");
                        Console.WriteLine("[1] Say 'I will get your bag'");
                        Console.WriteLine("[2] Say 'Im not your servent to command'");
                        Console.WriteLine("[3] Go back to dark hallway");
                        Console.WriteLine("[4] Check Inventory");
                        if (Playerstats[2] >= 3)
                        {
                            Console.WriteLine("[5] Say 'Ill do it for a price");
                        }

                        temp = Console.ReadLine();
                        if (string.IsNullOrEmpty(temp))
                        {
                            Console.WriteLine("Please Enter a valid input...");
                            Console.ReadLine();
                        }
                        choice = Convert.ToInt32(temp);

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Sir David : 'Good man, you wont regret it'");
                                Console.WriteLine("Sir David : 'Go down that hall and youll find the ladder to the celler");
                                Console.ReadLine();
                                BrokenHallState = 1;
                                BrokenHall();
                                break;
                            case 2:
                                Console.WriteLine("Sir David : 'Oh well good luck out there, your gonna need it'");
                                Console.ReadLine();
                                BrokenHallState = 1;
                                BrokenHall();
                                break;
                            case 3:
                                RightPath();
                                break;
                            case 4:
                                YourStuff(inventory);
                                break;
                            case 5:
                                Console.WriteLine("Sir David : 'If you get my bag you can have my pouch of coins'");
                                Console.WriteLine("Sir David : 'Go down that hall and youll find the ladder to the celler");
                                Console.ReadLine();
                                BrokenHallState = 1;
                                KnightDeal = true;
                                BrokenHall();
                                break;
                        }
                        break;
                    case 2:
                        Program.Battle(7, "Broken Hall");
                        Console.WriteLine("You have defeated Sir David in battle, he is dead");
                        Console.ReadLine();
                        Console.WriteLine("New Weapon ~Sir Davids Sword~");
                        Console.ReadLine();
                        inventory.Weapon = Program.weapon(4);
                        inventory.Wname = Program.weaponString(4);
                        BrokenHallState = 2;
                        break;
                    case 3:
                        int yourRoll = 0, enemyRoll = 0;
                        Random randy = new Random();
                        string[] enemyBarks = Program.EnemyBarks(6);
                        int[] enemyStats = Program.EnemyStats(6);
                        Console.WriteLine("You sneak with " + Playerstats[1] + " dice");
                        Console.ReadLine();
                        for (int i = 0; i < Playerstats[1]; i++)
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
                        Console.WriteLine("Your total sneak is " + yourRoll);
                        Console.WriteLine("The " + enemyBarks[5] + "s total check is " + enemyRoll);
                        Console.ReadLine();
                        Console.Clear();

                        if (yourRoll > enemyRoll)
                        {
                            Console.Clear();
                            Console.WriteLine("You sneak up to him \nSir David : 'I know your there, prisoner, dont try anything funny now'\n");
                            Console.WriteLine("[1] Attack");
                            Console.WriteLine("[2] Go back");

                            temp = Console.ReadLine();
                            if (string.IsNullOrEmpty(temp))
                            {
                                Console.WriteLine("Please Enter a valid input...");
                                Console.ReadLine();
                            }
                            choice = Convert.ToInt32(temp);

                            switch (choice)
                            {
                                case 1:
                                    Program.Battle(7, "Broken Hall");
                                    Console.WriteLine("You have defeated Sir David in battle, he is dead");
                                    Console.ReadLine();
                                    Console.WriteLine("New Weapon ~Sir Davids Sword~");
                                    Console.ReadLine();
                                    inventory.Weapon = Program.weapon(4);
                                    inventory.Wname = Program.weaponString(4);
                                    BrokenHallState = 2;
                                    break;
                                case 2:
                                    BrokenHall();
                                    break;
                            }


                        }
                        if (yourRoll < enemyRoll)
                        {
                            Console.Clear();
                            Console.WriteLine("You sneak up to him \nSir David : 'I know your there, prisoner, dont try anything funny now'\n");
                            Console.WriteLine("[1] Attack");
                            Console.WriteLine("[2] Go back");

                            temp = Console.ReadLine();
                            if (string.IsNullOrEmpty(temp))
                            {
                                Console.WriteLine("Please Enter a valid input...");
                                Console.ReadLine();
                            }
                            choice = Convert.ToInt32(temp);

                            switch (choice)
                            {
                                case 1:
                                    Program.Battle(7, "Broken Hall");
                                    Console.WriteLine("You have defeated Sir David in battle, he is dead");
                                    Console.ReadLine();
                                    Console.WriteLine("New Weapon ~Sir Davids Sword~");
                                    Console.ReadLine();
                                    inventory.Weapon = Program.weapon(4);
                                    inventory.Wname = Program.weaponString(4);
                                    BrokenHallState = 2;
                                    break;
                                case 2:
                                    BrokenHall();
                                    break;
                            }
                        }
                        break;
                    case 4:
                        RightPath();
                        break;
                    case 5:
                        YourStuff(inventory);
                        break;
                }
            }
            if (BrokenHallState == 1)
            {
                Console.Clear();
                Console.WriteLine("Your in an old hall, with a long table in the middile, the walls are decorated with tattered royal banners");
                Console.WriteLine("You see Sir David resting on the same pile of rubble tending to his wounds\n");
                Console.WriteLine("[1] Talk");
                Console.WriteLine("[2] Attack");
                Console.WriteLine("[3] Sneak");
                Console.WriteLine("[4] Move to Dark hallway");
                Console.WriteLine("[5] Move to Celler hatch");
                Console.WriteLine("[6] Check Inventory");

                temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Please Enter a valid input...");
                    Console.ReadLine();
                }
                choice = Convert.ToInt32(temp);

                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Sir David : 'You realy should be going, we dont want to stay down her too long, it might find us");
                        Console.ReadLine();
                        BrokenHall();
                        break;
                    case 2:
                        Program.Battle(7, "Broken Hall");
                        Console.WriteLine("You have defeated Sir David in battle, he is dead");
                        Console.ReadLine();
                        Console.WriteLine("New Weapon ~Sir Davids Sword~");
                        Console.ReadLine();
                        inventory.Weapon = Program.weapon(4);
                        inventory.Wname = Program.weaponString(4);
                        BrokenHallState = 2;
                        break;
                    case 3:
                        int yourRoll = 0, enemyRoll = 0;
                        Random randy = new Random();
                        string[] enemyBarks = Program.EnemyBarks(6);
                        int[] enemyStats = Program.EnemyStats(6);
                        Console.WriteLine("You sneak with " + Playerstats[1] + " dice");
                        Console.ReadLine();
                        for (int i = 0; i < Playerstats[1]; i++)
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
                        Console.WriteLine("Your total sneak is " + yourRoll);
                        Console.WriteLine("The " + enemyBarks[5] + "s total check is " + enemyRoll);
                        Console.ReadLine();
                        Console.Clear();

                        if (yourRoll > enemyRoll)
                        {
                            Console.Clear();
                            Console.WriteLine("You sneak up to him \nSir David : 'I know your there, prisoner, dont try anything funny now'\n");
                            Console.WriteLine("[1] Attack");
                            Console.WriteLine("[2] Go back");

                            temp = Console.ReadLine();
                            if (string.IsNullOrEmpty(temp))
                            {
                                Console.WriteLine("Please Enter a valid input...");
                                Console.ReadLine();
                            }
                            choice = Convert.ToInt32(temp);

                            switch (choice)
                            {
                                case 1:
                                    Program.Battle(7, "Broken Hall");
                                    Console.WriteLine("You have defeated Sir David in battle, he is dead");
                                    Console.ReadLine();
                                    Console.WriteLine("New Weapon ~Sir Davids Sword~");
                                    Console.ReadLine();
                                    inventory.Weapon = Program.weapon(4);
                                    inventory.Wname = Program.weaponString(4);
                                    BrokenHallState = 2;
                                    break;
                                case 2:
                                    BrokenHall();
                                    break;
                            }


                        }
                        if (yourRoll < enemyRoll)
                        {
                            Console.Clear();
                            Console.WriteLine("You sneak up to him \nSir David : 'I know your there, prisoner, dont try anything funny now'\n");
                            Console.WriteLine("[1] Attack");
                            Console.WriteLine("[2] Go back");

                            temp = Console.ReadLine();
                            if (string.IsNullOrEmpty(temp))
                            {
                                Console.WriteLine("Please Enter a valid input...");
                                Console.ReadLine();
                            }
                            choice = Convert.ToInt32(temp);

                            switch (choice)
                            {
                                case 1:
                                    Program.Battle(7, "Broken Hall");
                                    Console.WriteLine("You have defeated Sir David in battle, he is dead");
                                    Console.ReadLine();
                                    Console.WriteLine("New Weapon ~Sir Davids Sword~");
                                    Console.ReadLine();
                                    inventory.Weapon = Program.weapon(4);
                                    inventory.Wname = Program.weaponString(4);
                                    BrokenHallState = 2;
                                    break;
                                case 2:
                                    BrokenHall();
                                    break;
                            }
                        }
                        break;
                    case 4:
                        RightPath();
                        break;
                    case 5:
                        CellerHatch();
                        break;
                    case 6:
                        YourStuff(inventory);
                        BrokenHall();
                        break;
                }
            }

            if (BrokenHallState == 2)
            {
                Console.Clear();
                Console.WriteLine("Your in an old hall, with a long table in the middile, the walls are decorated with tattered royal banners");
                Console.WriteLine("You see Sir David resting on the same pile of rubble tending to his wounds");
                Console.WriteLine("[1] Move to Dark hallway");
                Console.WriteLine("[2] Move to Celler hatch");
                Console.WriteLine("[3] Check Inventory");

                temp = Console.ReadLine();
                if (string.IsNullOrEmpty(temp))
                {
                    Console.WriteLine("Please Enter a valid input...");
                    Console.ReadLine();
                }
                choice = Convert.ToInt32(temp);

                switch (choice)
                {
                    case 1:
                        RightPath();
                        break;
                    case 2:
                        CellerHatch();
                        break;
                    case 3:
                        YourStuff(inventory);
                        BrokenHall();
                        break;
                }

            }
        }

        public void CellerHatch()
        {
            Console.Clear();
            Console.WriteLine("To be continued");
            Console.WriteLine("[1] Return to the Broken hall");

            temp = Console.ReadLine();
            if (string.IsNullOrEmpty(temp))
            {
                Console.WriteLine("Please Enter a valid input...");
                Console.ReadLine();
            }
            choice = Convert.ToInt32(temp);

            switch (choice)
            {
                case 1:
                    BrokenHall();
                    break;
            }
        }

        public Bloodcage(int[] stats)
        {
            Program program = new Program();

            Playerstats = stats;

            StealKnife = false;
            KnightDeal = false;

            LeftPathBattle = false;
            BrokenHallState = 0;

            inventory.Weapon = Program.weapon(99);
            inventory.Wname = Program.weaponString(99);
            inventory.Clothing = Program.clothing(99);
            inventory.Cname = Program.clothingString(99);
            Backpack(0, 1);
            Backpack(99, 2);
            Backpack(99, 3);
            Backpack(99, 4);

            Wake();
        }
    }
}
