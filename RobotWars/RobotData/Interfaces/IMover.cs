using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.RobotData
{
    public interface IMover
    {
        IAgent Agent { get; }
        IArena Arena { get; }

        void RunInstructions(char[] insructions);
        void Move(char instruction);
    }
}
