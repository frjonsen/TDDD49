﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Model.Logic
{
    static class LogicEngine
    {
        public static int diceRoll()
        {
            throw new NotImplementedException();
        }

        public static bool containedIn(Game.Model.DataStructures.Point p, int height, int width)
        {
            return (p.X >= 0 && p.Y >= 0 && p.X < width && p.Y < height);
        }
    }
}
