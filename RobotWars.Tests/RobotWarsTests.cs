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
        RobotMover mover = null;
        Telemetry initial = null, expected = null;

        [TestInitialize]
        public void InitTest()
        {
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
            int expectedPenalties = 0;
            robot = new Robot(initial);
            mover = new RobotMover(robot);

            string instructions = "MLMRMMMRMMRR";

            // Act
            mover.RunInstructions(instructions.ToCharArray());

            // Assert
            Assert.AreEqual(initial, expected, "The location does not match the expected location");
            Assert.AreEqual(expectedPenalties, robot.Penalties, "Number of penalties does not match");
        }
    }
}
