﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.RobotData
{
    public interface IAgent
    {
        Telemetry AgentTelemetry { get; set; }
    }

}
