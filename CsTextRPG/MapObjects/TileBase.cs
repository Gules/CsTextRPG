using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SadConsole;
using Microsoft.Xna.Framework;

namespace CsTextRPG.MapObjects
{
    class TileBase :Cell
    {
        public bool IsBlockingMove;
        public bool IsBlockingLOS;

        public TileBase(Color foreground, Color background, int glyph) : base(foreground, background, glyph)
        {

        }
    }
}
