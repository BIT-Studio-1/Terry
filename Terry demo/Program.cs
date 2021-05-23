using System;

namespace Command_Line_Adventure
{
    class Program
    {
        public static string temp;
        public static int strength, stealth, cunning;     // These are universal variables 



        public static void Inventory()
        {
            string slot1 = "Empty", slot2 = "Empty", slot3 = "Empty", slot4 = "Empty";
            Console.WriteLine();
            Console.WriteLine("~Inventory~");
            Console.WriteLine("-----------");
            Console.WriteLine("  Item 1: " + slot1 + "\n" + "  Item 2: " + slot2 + "\n" + "  Item 3: " + slot3 + "\n" + "  Item 4: " + slot4);
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
                Console.WriteLine("- [1] Go to Hallway");
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
            Console.WriteLine("- [1] Go into the Dungeon");
            Console.WriteLine("- [2] Go Left ");
            Console.WriteLine("- [3] Go Right ");
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
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] Enter Armoury with Guards ");
            Console.WriteLine("- [3] Enter the Crematorium ");
            Console.WriteLine("- [4] Check Inventory");
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
                    ArmouryWithguards();
                    break;

                case 3:
                    Crematorium();
                    break;

                case 4:
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
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine("- [2] Enter Lair of the Beast ");
            Console.WriteLine("- [3] Enter the Locked Mystery Room ");
            Console.WriteLine("- [4] Check Inventory");
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
            Console.WriteLine("- [2] Check what's in the box");
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
        public static void ArmouryWithguards()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Armoury With Guards");
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

                case 3:
                    Inventory();
                    Console.WriteLine("PRESS ENTER");
                    ArmouryWithguards();
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
                    LeftHallway();
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
                    LeftHallway();
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
        public static void Main()
        {
            int Character;

            do { 
            Console.WriteLine("Choose a character: ");
            Console.WriteLine("Select: 1 for Strength, 2 for Stealth or 3 for Cunning.") ;
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
            if (temp == "1") {
                Inventory();
            }


            Dungeon();
            
            Console.ReadLine();
        }
    }
}