﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Robot
{
    public interface IMover
    {

        void Move(IAgent agent, char instruction);
    }
}
