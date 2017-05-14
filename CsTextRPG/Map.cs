using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using SadConsole.Surfaces;

namespace CsTextRPG
{
    class Map
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Entities.Player Player;

        public List<Entities.EntityBase> Entities;

        public MapObjects.TileBase[] Tiles;

        public BasicSurface Surface;

        public Map(int width, int height)
        {
            Width = width;
            Height = height;

            // Create our tiles for the map
            Tiles = new MapObjects.TileBase[width * height];

            // Fill the map with floors.
            for (int i = 0; i < Tiles.Length; i++)
                Tiles[i] = new MapObjects.Floor();

            // Create the text surface that the console will render, based on our tiles.
            Surface = new BasicSurface(width, height, Tiles, SadConsole.Global.FontDefault, new Rectangle(0, 0, Program.ScreenWidth, Program.ScreenHeight));

            // Set some temp walls
            // y * width + x = index of that x,y combination
            Tiles[5 * width + 5] = new MapObjects.Wall();
            Tiles[2 * width + 5] = new MapObjects.Wall();
            Tiles[10 * width + 29] = new MapObjects.Wall();
            Tiles[17 * width + 44] = new MapObjects.Wall();

            Surface.RenderArea = Surface.RenderArea;

            // Entity container
            Entities = new List<CsTextRPG.Entities.EntityBase>();

            // Add a player
            Player = new CsTextRPG.Entities.Player();
            Entities.Add(Player);
        }
    }
}
