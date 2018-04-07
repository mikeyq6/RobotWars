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
            switch(Agent.AgentTelemetry.Direction)
            {
                case CardinalDirection.North:
                    Agent.AgentTelemetry.Direction = CardinalDirection.West; break;
                case CardinalDirection.West:
                    Agent.AgentTelemetry.Direction = CardinalDirection.South; break;
                case CardinalDirection.South:
                    Agent.AgentTelemetry.Direction = CardinalDirection.East; break;
                case CardinalDirection.East:
                    Agent.AgentTelemetry.Direction = CardinalDirection.North; break;
            }
        }
        private void RotateRight()
        {
            switch (Agent.AgentTelemetry.Direction)
            {
                case CardinalDirection.North:
                    Agent.AgentTelemetry.Direction = CardinalDirection.East; break;
                case CardinalDirection.West:
                    Agent.AgentTelemetry.Direction = CardinalDirection.North; break;
                case CardinalDirection.South:
                    Agent.AgentTelemetry.Direction = CardinalDirection.West; break;
                case CardinalDirection.East:
                    Agent.AgentTelemetry.Direction = CardinalDirection.South; break;
            }
        }
        private void Advance()
        {
            if(Arena.IsFacingWall(Agent.AgentTelemetry))
            {
                Agent.Penalties++;
            }
            else
            {
                switch(Agent.AgentTelemetry.Direction)
                {
                    case CardinalDirection.North:
                        Agent.AgentTelemetry.UpdateY(Agent.AgentTelemetry.Location.Y+1); break;
                    case CardinalDirection.South:
                        Agent.AgentTelemetry.UpdateY(Agent.AgentTelemetry.Location.Y - 1); break;
                    case CardinalDirection.East:
                        Agent.AgentTelemetry.UpdateX(Agent.AgentTelemetry.Location.X + 1); break;
                    case CardinalDirection.West:
                        Agent.AgentTelemetry.UpdateX(Agent.AgentTelemetry.Location.X - 1); break;
                }
            }
        }
    }
}
