using System;

namespace Command_Line_Adventure
{
    class Program
    {
        private static int strength, stealth, cunning;     // These are universal variables 



        public static void Inventory()
        {
            string slot1 = "Empty", slot2 = "Empty", slot3 = "Empty", slot4 = "Empty";
            Console.WriteLine("~Inventory~");
            Console.WriteLine(slot1 + "\n" + slot2 + "\n" + slot3 + "\n" + slot4);
            Console.WriteLine("~Statistics~");
            Console.WriteLine($"Strength : {strength}");
            Console.WriteLine($"Stealth  : {stealth}");
            Console.WriteLine($"Cunning  : {cunning}");
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
                Console.WriteLine("- [3] Inventory");
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

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
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
        public static void ArmouryWithguards()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Armoury With Guards");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");
            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
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
        public static void Lairofthebeast()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Lair Of The Beast");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
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
        public static void Lockedmysteryroom()
        {
            string temp;
            int input;

            Console.Clear();
            Console.WriteLine("You are in the Locked Mystery Room");
            Console.WriteLine();
            Console.WriteLine("Your options are...");
            Console.WriteLine("- [1] Go backwards");

            Console.WriteLine();
            temp = Console.ReadLine();
            input = Convert.ToInt32(temp);
            Console.Clear();

            switch (input)
            {
                case 1:
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
        public static void Main()
        {
            string Character;

            Console.WriteLine("Choose a character: ");
            Console.WriteLine();
            Console.WriteLine("           Strength       Stealth        Cunning");
            Console.WriteLine("          ----------     ---------      ---------");
            Console.WriteLine("Strength:     3              1              1     ");
            Console.WriteLine("Stealth:      1              3              1     ");
            Console.WriteLine("Cunning:      1              1              3     ");



            Character = Console.ReadLine();
            switch (Character)
            {
                case "Strength":
                    strength = 3;
                    stealth = 1;
                    cunning = 1;
                    break;

                case "Stealth":
                    strength = 1;
                    stealth = 3;
                    cunning = 1;
                    break;

                case "Cunning":
                    strength = 1;
                    stealth = 1;
                    cunning = 3;
                    break;
            }
            Dungeon();
            Console.ReadLine();
        }
    }
}