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
        private Point location;

        public Point Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public CardinalDirection Direction { get; set; } = CardinalDirection.North;

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
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static bool operator ==(Telemetry t1, Telemetry t2)
        {
            return t1.Equals(t2);
        }
        public static bool operator !=(Telemetry t1, Telemetry t2)
        {
            return !t1.Equals(t2);
        }

        public override string ToString()
        {
            return $"{Location.X}, {Location.Y}, {ShortDirection()}";
        }

        public void UpdateX(int x)
        {
            location.X = x;
        }
        public void UpdateY(int y)
        {
            location.Y = y;
        }

        private char ShortDirection()
        {
            switch (Direction)
            {
                case CardinalDirection.East: return 'E';
                case CardinalDirection.North: return 'N';
                case CardinalDirection.South: return 'S';
                case CardinalDirection.West: return 'W';
            }
            return ' ';
        }
    }

    public enum CardinalDirection
    {
        North = 0, East = 1, South = 2, West = 3
    }


}
