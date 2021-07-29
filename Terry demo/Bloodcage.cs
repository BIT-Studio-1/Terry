using Command_Line_Adventure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Terry_demo
{
    public class Bloodcage
    {
        private Bloodcage()
        {

        }

        public void Wake()
        {
            Console.WriteLine("After many long nights in the cell, one day two guards drag you out and down the hall");
            Thread.Sleep(1000);
            Console.WriteLine("Guard 1: Quickly now, the blood cage yerns for more !");
            Thread.Sleep(1000);
            Console.WriteLine("Guard 2: haha cant wait to see this, Bloody fruit merchants am I right?");
            Thread.Sleep(1000);
            Console.WriteLine("Guard 1: heh yea, keep yer fruit to yourself!");

            main.battle();
        }

    }
}
