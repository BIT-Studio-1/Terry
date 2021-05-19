using System;

namespace Terry
{
    class Program
    {
        static void Main(string[] args)

        {
            string desition;
            int stealth = 1, strength = 1, cunning = 1;
            int result;
            bool victory = false;
            string item1 = "", item2 = "", item3 = "";
            Random rand = new Random();

            do
            {
                Console.WriteLine();
                Console.WriteLine("You wake up in your cell with a noise, it did sound like someone unlocked the gate.");
                do
                {
                    Console.WriteLine("What to do? ");
                    desition = Console.ReadLine();
                    switch (desition)
                    {
                        case "go":
                        case "open":
                            Console.WriteLine("You are in a long and dark hallway, you can hear someone snoring close to you . ");
                            Console.WriteLine("Would you like to check or not?");
                            break;
                        case "stay":
                            Console.WriteLine("You are afraid, but this may be your only chance to get out of here. ");
                            break;
                        default:
                            Console.WriteLine("Not a valid action ");
                            break;



                    }
                } while (desition != "open");
                desition = Console.ReadLine();
                switch (desition)
                {
                    case "yes":
                    case "y":
                        Console.WriteLine("The sleeping person seems to be a guard, there is a key hanging from his belt . ");
                        Console.WriteLine("Try to get the key? ");
                        if (stealth == 1)
                        {
                            Console.WriteLine($"Your stealth level is {stealth}. You need 3 or more to win ");
                        }
                        else if (stealth == 2)
                        {
                            Console.WriteLine($"Your stealth level is {stealth}. You need a 2 or more to win ");
                        }
                        else
                        {
                            Console.WriteLine($"Your stealth level is {stealth}. You need a 2 or more to win ");
                        }


                        Console.WriteLine("");
                        desition = Console.ReadLine();
                        if (desition == "yes")
                        {
                            switch (stealth)
                            {
                                case 1:
                                    Console.WriteLine("Stealth required = 3 ");
                                    result = rand.Next(1, 7);
                                    if (result >= 2)
                                    {
                                        Console.WriteLine($"Result: {result}. You stole the key. ");
                                        item1 = "key";
                                        victory = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Result: {result}. The guard woke up!!! You get caught and sent back to your cell.");

                                    }
                                    break;
                                case 2:
                                    Console.WriteLine("Stealth required = 2 ");
                                    result = rand.Next(1, 7);
                                    if (result >= 2)
                                    {
                                        Console.WriteLine($"Result: {result}. You stole the key. ");
                                        item1 = "key";
                                        victory = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Result: {result}. The guard woke up!!! You get caught and sent back to your cell.");

                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("Stealth required = 1 ");
                                    result = rand.Next(1, 7);
                                    if (result >= 1)
                                    {
                                        Console.WriteLine($"Result: {result}. You stole the key. ");
                                        item1 = "key";
                                        victory = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"Result: {result}. The guard woke up!!! You get caught and sent back to your cell.");

                                    }
                                    break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("The risk is not worth it. You keep walking. ");
                            victory = true;
                        }
                        break;

                    case "no":
                    case "n":
                        Console.WriteLine("The risk is not worth it. You keep walking. ");
                        victory = true;

                        break;


                    default:
                        Console.WriteLine("Not a valid action ");
                        break;

                }
            } while (victory != true);
            Console.WriteLine("You reach an end point. There is a door in front of you, but you need a key.");
            if ((item1 == "key" || item2 == "key" || item3 == "key"))
            {
                do
                {
                    Console.WriteLine("Do you want to try the key? ");
                    desition = Console.ReadLine();
                    switch (desition)
                    {
                        case "yes":
                        case "y":
                            Console.WriteLine("The key fits the hole and you get into a new room.");
                            break;
                        case "no":
                        case "n":
                            Console.WriteLine("It's nowhere else to go.");
                            break;

                    }
                } while (desition != "yes" && desition != "y");
            }
            else
            {
                Console.WriteLine("You dont have a key.");
            }





            Console.ReadLine();
        }
    }
}
