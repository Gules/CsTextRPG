using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CsTextRPG.Entities
{
    class EntityBase: SadConsole.GameHelpers.GameObject
    {
        public EntityBase(Color foreground, Color background, int glyph) : base(1, 1)
        {
            Animation.CurrentFrame[0].Foreground = foreground;
            Animation.CurrentFrame[0].Background = background;
            Animation.CurrentFrame[0].Glyph = glyph;
        }

        public void MoveBy(Point change)
        {
            Position += change;
        }
    }
}
