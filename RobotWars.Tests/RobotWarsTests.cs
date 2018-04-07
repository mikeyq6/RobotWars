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
        Arena arena = null;
        RobotMover mover = null;
        Telemetry initial = null, expected = null;

        [TestInitialize]
        public void InitTest()
        {
            initial = new Telemetry();
            expected = new Telemetry();
            arena = new Arena(5, 5);
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
            mover = new RobotMover(robot, arena);

            string instructions = "MLMRMMMRMMRR";

            // Act
            mover.RunInstructions(instructions.ToCharArray());

            // Assert
            Assert.AreEqual(initial, expected, "The location does not match the expected location");
            Assert.AreEqual(expectedPenalties, robot.Penalties, "Number of penalties does not match");
        }

        [TestMethod]
        public void TestScenario2()
        {
            // Arrange
            initial.Location = new Point(4, 4);
            initial.Direction = CardinalDirection.South;
            expected.Location = new Point(0, 1);
            expected.Direction = CardinalDirection.West;
            int expectedPenalties = 1;
            robot = new Robot(initial);
            mover = new RobotMover(robot, arena);

            string instructions = "LMLLMMLMMMRMM";

            // Act
            mover.RunInstructions(instructions.ToCharArray());

            // Assert
            Assert.AreEqual(initial, expected, "The location does not match the expected location");
            Assert.AreEqual(expectedPenalties, robot.Penalties, "Number of penalties does not match");
        }

        [TestMethod]
        public void TestScenario3()
        {
            // Arrange
            initial.Location = new Point(2, 2);
            initial.Direction = CardinalDirection.West;
            expected.Location = new Point(2, 2);
            expected.Direction = CardinalDirection.North;
            int expectedPenalties = 0;
            robot = new Robot(initial);
            mover = new RobotMover(robot, arena);

            string instructions = "MLMLMLM RMRMRMRM";

            // Act
            mover.RunInstructions(instructions.ToCharArray());

            // Assert
            Assert.AreEqual(initial, expected, "The location does not match the expected location");
            Assert.AreEqual(expectedPenalties, robot.Penalties, "Number of penalties does not match");
        }

        [TestMethod]
        public void TestScenario4()
        {
            // Arrange
            initial.Location = new Point(1, 3);
            initial.Direction = CardinalDirection.North;
            expected.Location = new Point(0, 0);
            expected.Direction = CardinalDirection.South;
            int expectedPenalties = 3;
            robot = new Robot(initial);
            mover = new RobotMover(robot, arena);

            string instructions = "MMLMMLMMMMM";

            // Act
            mover.RunInstructions(instructions.ToCharArray());

            // Assert
            Assert.AreEqual(initial, expected, "The location does not match the expected location");
            Assert.AreEqual(expectedPenalties, robot.Penalties, "Number of penalties does not match");
        }
    }
}
