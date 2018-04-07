using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RobotWars.RobotData
{
    public class Arena : IArena
    {
        public int Height { get; }

        public int Width { get; }

        public Arena(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public bool IsFacingWall(Telemetry telemetry)
        {
            switch(telemetry.Direction)
            {
                case CardinalDirection.North:
                    return telemetry.Location.Y == Height-1;
                case CardinalDirection.South:
                    return telemetry.Location.Y == 0;
                case CardinalDirection.East:
                    return telemetry.Location.X == Width-1;
                case CardinalDirection.West:
                    return telemetry.Location.X == 0;
            }
            return false;
        }
    }
}
