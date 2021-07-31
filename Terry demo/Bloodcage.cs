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
            public int Weapon;
            public string Wname;
            public int Clothing;
            public string Cname;
            public int Coins;
            public Items items;
        }

        public Program program;
        public int[] Playerstats;
        public Inventory inventory;

        public void Weapons(int X)
        {
            switch (X)
            {
                case 0:
                    inventory.Weapon = 0;
                    inventory.Wname = "~Fist~";
                    break;
                default:
                    inventory.Weapon = 0;
                    inventory.Wname = "~Fist~";
                    break;
            }
        }
        public void Clothing(int X)
        {
            switch (X)
            {
                case 0:
                    inventory.Clothing = 0;
                    inventory.Cname = "~Prisoner Rags~";
                    break;
                default:
                    inventory.Clothing = 0;
                    inventory.Cname = "~Naked~";
                    break;
            }
        }
        public void Backpack(int X, int S)
        {
            int IntMod = 0;
            string String = "";

            switch (X)
            {
                case 0:
                    IntMod = 1;
                    String = "~Bandage~";
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
            Console.WriteLine($"  Weapon    : {inventory.Wname}");
            Console.WriteLine($"  Cloathing : {inventory.Cname}");
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
            Console.WriteLine("You fall asleep, waking up to a looked door. Many days pass, only barely suviving on the scraps they gave you");
            //Thread.Sleep(2000);
            Console.WriteLine("Guard : You! get up, its your turn in the BloodCage");
            //Thread.Sleep(2000);
            Console.WriteLine("The guard chains you up and drags you down the hall \nThen throws you into a hallway");
            //Thread.Sleep(2000);
            Console.WriteLine("Guard : Id say good luck but even thats not gonna help you");
            Console.WriteLine("A metal gate drops in between you both and he walks away luaghing to himself");
            //Thread.Sleep(2000);
            Console.WriteLine(">");
            Console.ReadLine();
            Console.Clear();

            YourStuff(inventory);


        }
        public Bloodcage(int[] Playerstats)
        {
            Program program = new Program();

            this.Playerstats = Playerstats;

            Weapons(0);
            Clothing(0);
            Backpack(0, 1);
            Backpack(99, 2);
            Backpack(99, 3);
            Backpack(99, 4);

            Wake();
        }
    }
}
