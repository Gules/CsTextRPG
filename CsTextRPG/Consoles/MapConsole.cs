using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsTextRPG.Consoles
{
    class MapConsole : SadConsole.Console
    {
        public Map MapData;

        public MapConsole(Map mapData) : base(mapData.Surface)
        {
            MapData = mapData;

            foreach (var entity in mapData.Entities)
            {
                // Add each entity as a child object so it can be rendered.
                Children.Add(entity);
            }
        }
    }
}
