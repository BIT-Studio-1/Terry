using System;

namespace Command_Line_Adventure
{
    class Program
    {
        public static void Inventory()
        {
            string slot1 = "Empty", slot2 = "Empty", slot3 = "Empty", slot4 = "Empty";
            Console.WriteLine("~Inventory~");
            Console.WriteLine(slot1 + "\n" + slot2 + "\n" + slot3 + "\n" + slot4);
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
                Console.WriteLine();

                temp = Console.ReadLine();
                input = Convert.ToInt32(temp);
                Console.Clear();

                switch (input)
                {
                    case 1:
                        Hallway();
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
        public static void Hallway()
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

                    break;
                case 3:

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
            Dungeon();
            Console.ReadLine();
        }
    }
}
