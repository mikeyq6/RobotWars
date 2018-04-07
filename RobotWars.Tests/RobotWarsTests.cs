using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RobotWars.RobotData;
using System.Drawing;

namespace RobotWars.Tests
{
    [TestClass]
    public class RobotWarsTests
    {
        Robot robot = null;
        Telemetry initial = null, expected = null;

        [TestInitialize]
        public void InitTest()
        {
            robot = new Robot();
            initial = new Telemetry();
            expected = new Telemetry();
        }

        [TestMethod]
        public void TestScenario1()
        {
            // Arrange
            initial.Location = new Point(0, 2);
            initial.Direction = CardinalDirection.East;
            expected.Location = new Point(4,1);
            expected.Direction = CardinalDirection.North;

            string instructions = "MLMRMMMRMMRR";
        }
    }
}
