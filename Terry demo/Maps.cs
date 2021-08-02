using System;
using System.Collections.Generic;
using System.Text;

namespace Terry_demo
{
    class Maps
    {
        private string location;

        public Maps(string location)
        {
            this.location = location;
        }

        public void OutsideDungeon()
        {
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@" ________________________________________________________________________________ ");
            Console.WriteLine(@"||                                    /|                                       /||");
            Console.WriteLine(@"||__________________________________ / |_____________________________________ / ||");
            Console.WriteLine(@"||                                  |  |                                     |  ||");
            Console.WriteLine(@"||   ╔              ╗               |  |            ╔                 ╗      |  ||");
            Console.WriteLine(@"||    Guards Chamber                |  |             Lair of the Beast       |  ||");
            Console.WriteLine(@"||   ╚              ╝               |  |            ╚                 ╝      |  ||");
            Console.WriteLine(@"||__________________________________|__|_____________________________________|__||");
            Console.WriteLine(@"||               /|            /  /            /  /          /|                /||");
            Console.WriteLine(@"||______________/ |___________/^_/____________/^_/_________ / |______________ / ||");
            Console.WriteLine(@"||╔           ╗|  | ╔       ╗                              |  |              |  ||");
            Console.WriteLine(@"|| Crematorium |  |  Hallway                               |  |              |  ||");
            Console.WriteLine(@"||╚           ╝|  | ╚       ╝______________________        |  |              |  ||");
            Console.WriteLine(@"||             |  |        / |           /  /     /|       |  |              |  ||");
            Console.WriteLine(@"||             | /|       /  |__________/^_/____ / |       |  |              |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|              |  ||");
            Console.WriteLine(@"||             | /|       |  |                  |  |       |/ |   ╔      ╗   |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|    Locked    |  ||");
            Console.WriteLine(@"||_____________|__|       |  |      ╔       ╗   |  |       |/ |    Mystery   |  ||");
            Console.WriteLine(@"||               /|       |  |       Dungeon    |  |       |  |     Room     |  ||");
            Console.WriteLine(@"||_____________ / |       |  |      ╚       ╝   |  |       |  |   ╚      ╝   |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |__________________|__|       |  |              |  ||");
            Console.WriteLine(@"||             |  |       | /                     /        |  |              |  ||");
            Console.WriteLine(@"||             |  |       |/_____________________/         |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |________________________________________|__|______________|__||");
            Console.WriteLine(@"||             | /      /  /        /|                /  /                     /||");
            Console.WriteLine(@"||             |/______/^_/_______ / |_______________/^_/____________________ / ||");
            Console.WriteLine(@"||                                |  |                                       |  ||");
            Console.WriteLine(@"||   ╔             ╗              |  |   ╔             ╗                     |  ||");
            Console.WriteLine(@"||    Heavy Dungeon               |  |    Empty Armoury                      |  ||");
            Console.WriteLine(@"||   ╚             ╝              |  |   ╚             ╝                     |  ||");
            Console.WriteLine(@"||________________________________|__|_______________________________________|__||");
        }
        public void OutsideLairOfTheBeast()
        {
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@" ________________________________________________________________________________ ");
            Console.WriteLine(@"||                                    /|                                       /||");
            Console.WriteLine(@"||__________________________________ / |_____________________________________ / ||");
            Console.WriteLine(@"||                                  |  |                                     |  ||");
            Console.WriteLine(@"||   ╔              ╗               |  |            ╔                 ╗      |  ||");
            Console.WriteLine(@"||    Guards Chamber                |  |             Lair of the Beast       |  ||");
            Console.WriteLine(@"||   ╚              ╝               |  |            ╚                 ╝      |  ||");
            Console.WriteLine(@"||__________________________________|__|_____________________________________|__||");
            Console.WriteLine(@"||               /|            /  /            /  /          /|                /||");
            Console.WriteLine(@"||______________/ |___________/^_/____________/^_/_________ / |______________ / ||");
            Console.WriteLine(@"||╔           ╗|  | ╔       ╗                              |  |              |  ||");
            Console.WriteLine(@"|| Crematorium |  |  Hallway                               |  |              |  ||");
            Console.WriteLine(@"||╚           ╝|  | ╚       ╝______________________        |  |              |  ||");
            Console.WriteLine(@"||             |  |        / |           /  /     /|       |  |              |  ||");
            Console.WriteLine(@"||             | /|       /  |__________/^_/____ / |       |  |              |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|              |  ||");
            Console.WriteLine(@"||             | /|       |  |                  |  |       |/ |   ╔      ╗   |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|    Locked    |  ||");
            Console.WriteLine(@"||_____________|__|       |  |      ╔       ╗   |  |       |/ |    Mystery   |  ||");
            Console.WriteLine(@"||               /|       |  |       Dungeon    |  |       |  |     Room     |  ||");
            Console.WriteLine(@"||_____________ / |       |  |      ╚       ╝   |  |       |  |   ╚      ╝   |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |__________________|__|       |  |              |  ||");
            Console.WriteLine(@"||             |  |       | /                     /        |  |              |  ||");
            Console.WriteLine(@"||             |  |       |/_____________________/         |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |________________________________________|__|______________|__||");
            Console.WriteLine(@"||             | /      /  /        /|                /  /                     /||");
            Console.WriteLine(@"||             |/______/^_/_______ / |_______________/^_/____________________ / ||");
            Console.WriteLine(@"||                                |  |                                       |  ||");
            Console.WriteLine(@"||   ╔             ╗              |  |   ╔             ╗                     |  ||");
            Console.WriteLine(@"||    Heavy Dungeon               |  |    Empty Armoury                      |  ||");
            Console.WriteLine(@"||   ╚             ╝              |  |   ╚             ╝                     |  ||");
            Console.WriteLine(@"||________________________________|__|_______________________________________|__||");
        }
        public void OutsideCrematorium()
        {
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@" ________________________________________________________________________________ ");
            Console.WriteLine(@"||                                    /|                                       /||");
            Console.WriteLine(@"||__________________________________ / |_____________________________________ / ||");
            Console.WriteLine(@"||                                  |  |                                     |  ||");
            Console.WriteLine(@"||   ╔              ╗               |  |            ╔                 ╗      |  ||");
            Console.WriteLine(@"||    Guards Chamber                |  |             Lair of the Beast       |  ||");
            Console.WriteLine(@"||   ╚              ╝               |  |            ╚                 ╝      |  ||");
            Console.WriteLine(@"||__________________________________|__|_____________________________________|__||");
            Console.WriteLine(@"||               /|            /  /            /  /          /|                /||");
            Console.WriteLine(@"||______________/ |___________/^_/____________/^_/_________ / |______________ / ||");
            Console.WriteLine(@"||╔           ╗|  | ╔       ╗                              |  |              |  ||");
            Console.WriteLine(@"|| Crematorium |  |  Hallway                               |  |              |  ||");
            Console.WriteLine(@"||╚           ╝|  | ╚       ╝______________________        |  |              |  ||");
            Console.WriteLine(@"||             |  |        / |           /  /     /|       |  |              |  ||");
            Console.WriteLine(@"||             | /|       /  |__________/^_/____ / |       |  |              |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|              |  ||");
            Console.WriteLine(@"||             | /|       |  |                  |  |       |/ |   ╔      ╗   |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|    Locked    |  ||");
            Console.WriteLine(@"||_____________|__|       |  |      ╔       ╗   |  |       |/ |    Mystery   |  ||");
            Console.WriteLine(@"||               /|       |  |       Dungeon    |  |       |  |     Room     |  ||");
            Console.WriteLine(@"||_____________ / |       |  |      ╚       ╝   |  |       |  |   ╚      ╝   |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |__________________|__|       |  |              |  ||");
            Console.WriteLine(@"||             |  |       | /                     /        |  |              |  ||");
            Console.WriteLine(@"||             |  |       |/_____________________/         |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |________________________________________|__|______________|__||");
            Console.WriteLine(@"||             | /      /  /        /|                /  /                     /||");
            Console.WriteLine(@"||             |/______/^_/_______ / |_______________/^_/____________________ / ||");
            Console.WriteLine(@"||                                |  |                                       |  ||");
            Console.WriteLine(@"||   ╔             ╗              |  |   ╔             ╗                     |  ||");
            Console.WriteLine(@"||    Heavy Dungeon               |  |    Empty Armoury                      |  ||");
            Console.WriteLine(@"||   ╚             ╝              |  |   ╚             ╝                     |  ||");
            Console.WriteLine(@"||________________________________|__|_______________________________________|__||");
        }
        public void OutsideEmptyArmoury()
        {
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@" ________________________________________________________________________________ ");
            Console.WriteLine(@"||                                    /|                                       /||");
            Console.WriteLine(@"||__________________________________ / |_____________________________________ / ||");
            Console.WriteLine(@"||                                  |  |                                     |  ||");
            Console.WriteLine(@"||   ╔              ╗               |  |            ╔                 ╗      |  ||");
            Console.WriteLine(@"||    Guards Chamber                |  |             Lair of the Beast       |  ||");
            Console.WriteLine(@"||   ╚              ╝               |  |            ╚                 ╝      |  ||");
            Console.WriteLine(@"||__________________________________|__|_____________________________________|__||");
            Console.WriteLine(@"||               /|            /  /            /  /          /|                /||");
            Console.WriteLine(@"||______________/ |___________/^_/____________/^_/_________ / |______________ / ||");
            Console.WriteLine(@"||╔           ╗|  | ╔       ╗                              |  |              |  ||");
            Console.WriteLine(@"|| Crematorium |  |  Hallway                               |  |              |  ||");
            Console.WriteLine(@"||╚           ╝|  | ╚       ╝______________________        |  |              |  ||");
            Console.WriteLine(@"||             |  |        / |           /  /     /|       |  |              |  ||");
            Console.WriteLine(@"||             | /|       /  |__________/^_/____ / |       |  |              |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|              |  ||");
            Console.WriteLine(@"||             | /|       |  |                  |  |       |/ |   ╔      ╗   |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|    Locked    |  ||");
            Console.WriteLine(@"||_____________|__|       |  |      ╔       ╗   |  |       |/ |    Mystery   |  ||");
            Console.WriteLine(@"||               /|       |  |       Dungeon    |  |       |  |     Room     |  ||");
            Console.WriteLine(@"||_____________ / |       |  |      ╚       ╝   |  |       |  |   ╚      ╝   |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |__________________|__|       |  |              |  ||");
            Console.WriteLine(@"||             |  |       | /                     /        |  |              |  ||");
            Console.WriteLine(@"||             |  |       |/_____________________/         |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |________________________________________|__|______________|__||");
            Console.WriteLine(@"||             | /      /  /        /|                /  /                     /||");
            Console.WriteLine(@"||             |/______/^_/_______ / |_______________/^_/____________________ / ||");
            Console.WriteLine(@"||                                |  |                                       |  ||");
            Console.WriteLine(@"||   ╔             ╗              |  |   ╔             ╗                     |  ||");
            Console.WriteLine(@"||    Heavy Dungeon               |  |    Empty Armoury                      |  ||");
            Console.WriteLine(@"||   ╚             ╝              |  |   ╚             ╝                     |  ||");
            Console.WriteLine(@"||________________________________|__|_______________________________________|__||");
            
        }
        public void OutsideGuardsChamber()
        {
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@" ________________________________________________________________________________ ");
            Console.WriteLine(@"||                                    /|                                       /||");
            Console.WriteLine(@"||__________________________________ / |_____________________________________ / ||");
            Console.WriteLine(@"||                                  |  |                                     |  ||");
            Console.WriteLine(@"||   ╔              ╗               |  |            ╔                 ╗      |  ||");
            Console.WriteLine(@"||    Guards Chamber                |  |             Lair of the Beast       |  ||");
            Console.WriteLine(@"||   ╚              ╝               |  |            ╚                 ╝      |  ||");
            Console.WriteLine(@"||__________________________________|__|_____________________________________|__||");
            Console.WriteLine(@"||               /|            /  /            /  /          /|                /||");
            Console.WriteLine(@"||______________/ |___________/^_/____________/^_/_________ / |______________ / ||");
            Console.WriteLine(@"||╔           ╗|  | ╔       ╗                              |  |              |  ||");
            Console.WriteLine(@"|| Crematorium |  |  Hallway                               |  |              |  ||");
            Console.WriteLine(@"||╚           ╝|  | ╚       ╝______________________        |  |              |  ||");
            Console.WriteLine(@"||             |  |        / |           /  /     /|       |  |              |  ||");
            Console.WriteLine(@"||             | /|       /  |__________/^_/____ / |       |  |              |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|              |  ||");
            Console.WriteLine(@"||             | /|       |  |                  |  |       |/ |   ╔      ╗   |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|    Locked    |  ||");
            Console.WriteLine(@"||_____________|__|       |  |      ╔       ╗   |  |       |/ |    Mystery   |  ||");
            Console.WriteLine(@"||               /|       |  |       Dungeon    |  |       |  |     Room     |  ||");
            Console.WriteLine(@"||_____________ / |       |  |      ╚       ╝   |  |       |  |   ╚      ╝   |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |__________________|__|       |  |              |  ||");
            Console.WriteLine(@"||             |  |       | /                     /        |  |              |  ||");
            Console.WriteLine(@"||             |  |       |/_____________________/         |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |________________________________________|__|______________|__||");
            Console.WriteLine(@"||             | /      /  /        /|                /  /                     /||");
            Console.WriteLine(@"||             |/______/^_/_______ / |_______________/^_/____________________ / ||");
            Console.WriteLine(@"||                                |  |                                       |  ||");
            Console.WriteLine(@"||   ╔             ╗              |  |   ╔             ╗                     |  ||");
            Console.WriteLine(@"||    Heavy Dungeon               |  |    Empty Armoury                      |  ||");
            Console.WriteLine(@"||   ╚             ╝              |  |   ╚             ╝                     |  ||");
            Console.WriteLine(@"||________________________________|__|_______________________________________|__||");
        }
        public void OutsideHeavyDungeon()
        {
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@" ________________________________________________________________________________ ");
            Console.WriteLine(@"||                                    /|                                       /||");
            Console.WriteLine(@"||__________________________________ / |_____________________________________ / ||");
            Console.WriteLine(@"||                                  |  |                                     |  ||");
            Console.WriteLine(@"||   ╔              ╗               |  |            ╔                 ╗      |  ||");
            Console.WriteLine(@"||    Guards Chamber                |  |             Lair of the Beast       |  ||");
            Console.WriteLine(@"||   ╚              ╝               |  |            ╚                 ╝      |  ||");
            Console.WriteLine(@"||__________________________________|__|_____________________________________|__||");
            Console.WriteLine(@"||               /|            /  /            /  /          /|                /||");
            Console.WriteLine(@"||______________/ |___________/^_/____________/^_/_________ / |______________ / ||");
            Console.WriteLine(@"||╔           ╗|  | ╔       ╗                              |  |              |  ||");
            Console.WriteLine(@"|| Crematorium |  |  Hallway                               |  |              |  ||");
            Console.WriteLine(@"||╚           ╝|  | ╚       ╝______________________        |  |              |  ||");
            Console.WriteLine(@"||             |  |        / |           /  /     /|       |  |              |  ||");
            Console.WriteLine(@"||             | /|       /  |__________/^_/____ / |       |  |              |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|              |  ||");
            Console.WriteLine(@"||             | /|       |  |                  |  |       |/ |   ╔      ╗   |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|    Locked    |  ||");
            Console.WriteLine(@"||_____________|__|       |  |      ╔       ╗   |  |       |/ |    Mystery   |  ||");
            Console.WriteLine(@"||               /|       |  |       Dungeon    |  |       |  |     Room     |  ||");
            Console.WriteLine(@"||_____________ / |       |  |      ╚       ╝   |  |       |  |   ╚      ╝   |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |__________________|__|       |  |              |  ||");
            Console.WriteLine(@"||             |  |       | /                     /        |  |              |  ||");
            Console.WriteLine(@"||             |  |       |/_____________________/         |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |________________________________________|__|______________|__||");
            Console.WriteLine(@"||             | /      /  /        /|                /  /                     /||");
            Console.WriteLine(@"||             |/______/^_/_______ / |_______________/^_/____________________ / ||");
            Console.WriteLine(@"||                                |  |                                       |  ||");
            Console.WriteLine(@"||   ╔             ╗              |  |   ╔             ╗                     |  ||");
            Console.WriteLine(@"||    Heavy Dungeon               |  |    Empty Armoury                      |  ||");
            Console.WriteLine(@"||   ╚             ╝              |  |   ╚             ╝                     |  ||");
            Console.WriteLine(@"||________________________________|__|_______________________________________|__||");
        }
        public void OutsideMysteryRoom()
        {
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@"");
            Console.WriteLine(@" ________________________________________________________________________________ ");
            Console.WriteLine(@"||                                    /|                                       /||");
            Console.WriteLine(@"||__________________________________ / |_____________________________________ / ||");
            Console.WriteLine(@"||                                  |  |                                     |  ||");
            Console.WriteLine(@"||   ╔              ╗               |  |            ╔                 ╗      |  ||");
            Console.WriteLine(@"||    Guards Chamber                |  |             Lair of the Beast       |  ||");
            Console.WriteLine(@"||   ╚              ╝               |  |            ╚                 ╝      |  ||");
            Console.WriteLine(@"||__________________________________|__|_____________________________________|__||");
            Console.WriteLine(@"||               /|            /  /            /  /          /|                /||");
            Console.WriteLine(@"||______________/ |___________/^_/____________/^_/_________ / |______________ / ||");
            Console.WriteLine(@"||╔           ╗|  | ╔       ╗                              |  |              |  ||");
            Console.WriteLine(@"|| Crematorium |  |  Hallway                               |  |              |  ||");
            Console.WriteLine(@"||╚           ╝|  | ╚       ╝______________________        |  |              |  ||");
            Console.WriteLine(@"||             |  |        / |           /  /     /|       |  |              |  ||");
            Console.WriteLine(@"||             | /|       /  |__________/^_/____ / |       |  |              |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|              |  ||");
            Console.WriteLine(@"||             | /|       |  |                  |  |       |/ |   ╔      ╗   |  ||");
            Console.WriteLine(@"||             |/ |       |  |                  |  |       | /|    Locked    |  ||");
            Console.WriteLine(@"||_____________|__|       |  |      ╔       ╗   |  |       |/ |    Mystery   |  ||");
            Console.WriteLine(@"||               /|       |  |       Dungeon    |  |       |  |     Room     |  ||");
            Console.WriteLine(@"||_____________ / |       |  |      ╚       ╝   |  |       |  |   ╚      ╝   |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |                  |  |       |  |              |  ||");
            Console.WriteLine(@"||             |  |       |  |__________________|__|       |  |              |  ||");
            Console.WriteLine(@"||             |  |       | /                     /        |  |              |  ||");
            Console.WriteLine(@"||             |  |       |/_____________________/         |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |                                        |  |              |  ||");
            Console.WriteLine(@"||             |  |________________________________________|__|______________|__||");
            Console.WriteLine(@"||             | /      /  /        /|                /  /                     /||");
            Console.WriteLine(@"||             |/______/^_/_______ / |_______________/^_/____________________ / ||");
            Console.WriteLine(@"||                                |  |                                       |  ||");
            Console.WriteLine(@"||   ╔             ╗              |  |   ╔             ╗                     |  ||");
            Console.WriteLine(@"||    Heavy Dungeon               |  |    Empty Armoury                      |  ||");
            Console.WriteLine(@"||   ╚             ╝              |  |   ╚             ╝                     |  ||");
            Console.WriteLine(@"||________________________________|__|_______________________________________|__||");
        }
    }
}
