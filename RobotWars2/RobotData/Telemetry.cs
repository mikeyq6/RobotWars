using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.RobotData
{
    public class Telemetry
    {
        public Point Location { get; set; }
        public CardinalDirection Direction { get; set; }
    }

    public enum CardinalDirection
    {
        North = 0, East = 1, South = 2, West = 3
    }
}
