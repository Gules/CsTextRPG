using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace CsTextRPG.MapObjects
{
    class Floor : TileBase
    {
        public Floor() : base(new Color(25, 25, 25), Color.Black, 46)
        {
            IsBlockingLOS = false;
            IsBlockingMove = false;
        }
    }
}
