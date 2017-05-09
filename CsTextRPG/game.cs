using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;

namespace CsTextRPG
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Character player = new Character();
            player.name = name;
            player.Rouge();
            Console.WriteLine("Hello {0} the {1}", player.name, player.clas);
            Quit();

        }
        public static void Quit()
        {
            Console.WriteLine("press any key to exit");
            Console.ReadLine();
        }

    }

    class Character
	{
		public int lvl = 1;
		public int sp = 10;
		public string name;
		public Array items;
		public int exp=0;
		public int gold=0;
		public int limit=1;
		public int hp;
		public int chp;
		public int m;
		public int cm;
		public int inte;
		public int str;
		public int def;
		public int dex;
		public int agi;
		public string clas = "test";

		public void Rouge()
		{
            clas = "Rouge";
            Console.WriteLine(clas);
            Console.WriteLine("rouge class");
            Console.WriteLine("exp: {0}",exp);
			hp = 25;
			chp = 25;
			m = 15;
			cm = 15;
			inte = 10;
			str = 15;
			def = 10;
			dex = 20;
			agi = 25;
            
		}
	}
}
