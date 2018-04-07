using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.RobotData
{
    public class Robot : IAgent
    {
        public Telemetry AgentTelemetry { get; }
        public int Penalties { get; } = 0;

        public Robot(Telemetry agentTelemetry)
        {
            AgentTelemetry = agentTelemetry;
        }
    }
}
