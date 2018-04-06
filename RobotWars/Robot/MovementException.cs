using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Robot
{
    public class MovementException : Exception
    {
        public MovementException(string message, Exception innerException) : base(message, innerException)  { }

        public MovementException(string message) : base(message) { }
    }
}
