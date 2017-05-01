using System;

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
            Console.WriteLine("Hello {0} the {1}", player.name, Character.clas);
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
		public static string clas = "test";

		public void Rouge()
		{
            clas = "Rouge";
            Console.WriteLine(clas);
            Console.WriteLine("rouge class");
            Console.WriteLine("exp: {0}",exp);
			int hp = 25;
			int chp = 25;
			int m = 15;
			int cm = 15;
			int inte = 10;
			int str = 15;
			int de = 10;
			int dex = 20;
			int agi = 25;
            
		}
	}
}
