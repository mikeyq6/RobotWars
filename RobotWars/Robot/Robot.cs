using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotWars.Robot
{
    public class Robot
    {
        public Telemetry RobotTelemetry { get; set; }

        public Robot()
        {

        }

        public void Move(char instruction)
        {
            switch (instruction) {
                case 'L':
                    RotateLeft(); break;
                case 'R':
                    RotateRight(); break;
                case 'M':
                    Move(); break;
            }

        }

        private void RotateLeft()
        {
            ;
        }
        private void RotateRight()
        {
            ;
        }
        private void Move()
        {
            ;
        }
    }
}
