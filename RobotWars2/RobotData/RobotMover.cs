using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.RobotData
{
    public class RobotMover : IMover
    {


        public void Move(IAgent robot, char instruction)
        {
            switch (instruction)
            {
                case 'L':
                    RotateLeft(robot); break;
                case 'R':
                    RotateRight(robot); break;
                case 'M':
                    Advance(robot); break;
            }
        }

        private void RotateLeft(IAgent robot)
        {
            robot.AgentTelemetry.Direction = (CardinalDirection)(((int)robot.AgentTelemetry.Direction - 1) % 4);
        }
        private void RotateRight(IAgent robot)
        {
            robot.AgentTelemetry.Direction = (CardinalDirection)(((int)robot.AgentTelemetry.Direction + 1) % 4);
        }
        private void Advance(IAgent robot)
        {
            ;
        }
    }
}
