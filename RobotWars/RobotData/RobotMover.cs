using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.RobotData
{
    public class RobotMover : IMover
    {
        public IAgent Agent { get; }
        public IArena Arena { get; }

        public RobotMover(IAgent agent, IArena arena)
        {
            Agent = agent;
            Arena = arena;
        }

        public void RunInstructions(char[] insructions)
        {
            foreach(char ins in insructions)
            {
                Move(ins);
            }
        }

        public void Move(char instruction)
        {
            switch (instruction)
            {
                case 'L':
                    RotateLeft(); break;
                case 'R':
                    RotateRight(); break;
                case 'M':
                    Advance(); break;
                default:
                    break; // Ignore any other kinds of codes
            }
        }

        private void RotateLeft()
        {
            Agent.AgentTelemetry.Direction = (CardinalDirection)(((int)Agent.AgentTelemetry.Direction - 1) % 4);
        }
        private void RotateRight()
        {
            Agent.AgentTelemetry.Direction = (CardinalDirection)(((int)Agent.AgentTelemetry.Direction + 1) % 4);
        }
        private void Advance()
        {
            ;
        }
    }
}
