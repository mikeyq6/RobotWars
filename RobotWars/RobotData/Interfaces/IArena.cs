using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWars.RobotData
{
    public interface IArena
    {
        int Width { get; }
        int Height { get; }
        bool IsFacingWall(CardinalDirection direction);
    }
}
