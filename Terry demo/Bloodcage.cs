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

        public bool LeftPathBattle;

       //public void Weapons(int X)
       //{
       //    switch (X)
       //    {
       //        case 0:
       //            inventory.Weapon = ;
       //            inventory.Wname = "~Fist~";
       //            break;
       //        case 1:
       //            inventory.Weapon = 1;
       //        default:
       //            inventory.Weapon = 0;
       //            inventory.Wname = "~Fist~";
       //            break;
       //    }
       //}
       //public void Clothing(int X)
       //{
       //    switch (X)
       //    {
       //        case 0:
       //            inventory.Clothing = 0;
       //            inventory.Cname = "~Prisoner Rags~";
       //            break;
       //        default:
       //            inventory.Clothing = 0;
       //            inventory.Cname = "~Naked~";
       //            break;
       //    }
       //}
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
            choice = 0;
            Console.WriteLine("You fall asleep, waking up to a looked door. Many days pass, only barely suviving on the scraps they gave you");
            Console.WriteLine("Guard : You! get up, its your turn in the BloodCage\n\n");
            Console.WriteLine("The guard chains you up and drags you down the hall, then throws you into the Ruins");
            Console.WriteLine("Guard : Id say good luck but even thats not gonna help you\n\n");
            Console.WriteLine("A metal gate drops in between you both and he walks away luaghing to himself");
            Console.WriteLine("[1] Move into the scary Ruins");
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
                default:
                    break;
            }
        }

        public void Ruins()
        {
            Console.Clear();
            Console.WriteLine("You enter the ruins, ruble and broken podiums litter the room");
            Console.WriteLine("There are two paths, one on the left and one on the right");
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
            if (LeftPathBattle == false)
            {
                Console.Clear();
                Console.WriteLine("You see a scared man muttering to himself in this empty room");
                Console.WriteLine("He does not seem to notice you");
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
                        Console.WriteLine("Scared man : 'we are all gonna die, its coming for us'");
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
                        Console.WriteLine("You defeated the Prisoner\nYou see hes got a Knife");
                        Console.WriteLine("[1] Take his Knife");
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
                        Console.ReadLine();
                        Console.WriteLine("The " + enemyBarks[5] + "s total check is " + enemyRoll);
                        Console.ReadLine();
                        Console.Clear();

                        if (yourRoll > enemyRoll)
                        {
                            Console.WriteLine("You can see a Knife in his bag, he still hasent noticed you");
                            Console.WriteLine("[1] Steal the Knife");
                            Console.WriteLine("[2] Sneak Back");
                        }
                        if (yourRoll < enemyRoll)
                        {
                            Console.WriteLine("Scared man : 'Huh?! Stay BACK!'");
                            Program.Battle(6, "Empty Ruin");
                            Console.WriteLine("You killed the Prisoner\nYou see hes got a Knife");
                            Console.WriteLine("[1] Take his Knife");
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
                                Console.ReadLine();
                            }
                            LeftPathBattle = true;
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
                Console.WriteLine("You see the Prisoners corpse on the ground");
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
            Console.Clear();
            Console.WriteLine("You enter a dark hallway, you see a light at the end of the hallway");
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

            }
        }

        public Bloodcage(int[] Playerstats)
        {
            Program program = new Program();

            this.Playerstats = Playerstats;

            LeftPathBattle = false;

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
