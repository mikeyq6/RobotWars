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


        public override bool Equals(object value)
        {
            if (value == null)
                return false;

            Telemetry t = (Telemetry)value;
            return
                t.Location.X == Location.X &&
                t.Location.Y == Location.Y &&
                t.Direction == Direction;
        }

        public static bool operator ==(Telemetry t1, Telemetry t2)
        {
            return t1.Equals(t2);
        }
        public static bool operator !=(Telemetry t1, Telemetry t2)
        {
            return !t1.Equals(t2);
        }
    }

    public enum CardinalDirection
    {
        North = 0, East = 1, South = 2, West = 3
    }


}
