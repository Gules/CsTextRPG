using System;
using SadConsole;
using Console = SadConsole.Console;
using Microsoft.Xna.Framework;

namespace CsTextRPG
{
    class Program
    {

        public const int ScreenWidth = 80;
        public const int ScreenHeight = 25;
        public static Consoles.MapConsole MapConsole;

        static void Main(string[] args)
        {
            //creating player
            Character player = new Character();

            // Setup the engine and creat the main window.
            SadConsole.Game.Create("IBM.font", ScreenWidth, ScreenHeight);

            // Hook the start event so we can add consoles to the system.
            SadConsole.Game.OnInitialize = Init;

            // Hook the update event that happens each frame so we can trap keys and respond.
            SadConsole.Game.OnUpdate = Update;
                        
            // Start the game.
            SadConsole.Game.Instance.Run();

            //
            // Code here will not run until the game window closes.
            //
        }
        
        private static void Update(GameTime time)
        {
            // Called each logic update.

            // As an example, we'll use the F5 key to make the game full screen
            if (SadConsole.Global.KeyboardState.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys.F5))
            {
                SadConsole.Settings.ToggleFullScreen();
            }
            if (SadConsole.Global.KeyboardState.IsKeyReleased(Microsoft.Xna.Framework.Input.Keys.Escape))
            {
                SadConsole.Game.Instance.Exit();
            }
        }

        private static void Init()
        {
            /* Any custom loading and prep. We will use a sample console for now

            Console startingConsole = new Console(Width, Height);
            startingConsole.FillWithRandomGarbage();
            startingConsole.Fill(new Rectangle(3, 3, 27, 5), null, Color.Black, 0);
            startingConsole.Print(6, 5, "Hello from SadConsole", ColorAnsi.CyanBright);

            // Set our new console as the thing to render and process
            SadConsole.Global.CurrentScreen = startingConsole;
            //my stuff
            SadConsole.Console startingConsole = new Console(ScreenWidth, ScreenHeight);
            startingConsole.Print(ScreenWidth / 2, ScreenHeight / 2, "@", ColorAnsi.CyanBright);
            SadConsole.Global.CurrentScreen = startingConsole;
            */
            // Create the map
            Map mapData = new Map(100, 100);

            // Position the player near the middle of the screen
            mapData.Player.Position = new Point(ScreenWidth / 2, ScreenHeight / 2);

            // Create our map console and add it to SadConsole
            MapConsole = new Consoles.MapConsole(mapData);

            SadConsole.Global.CurrentScreen.Children.Add(MapConsole);

            // The map console will now get the keyboard hook triggered
            SadConsole.Global.FocusedConsoles.Set(MapConsole);
        }
        class Character
        {
            public int posX = ScreenWidth / 2;
            public int posY = ScreenHeight / 2;
        }
    }
}
