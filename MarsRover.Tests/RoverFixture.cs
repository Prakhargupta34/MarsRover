using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverFixture
    {
        [Fact]
        public void Rover_can_store_current_location_vector_test()
        {

            Coordinate coordinate = new Coordinate() { X = 1, Y = 3 };
            PositionVector positiontionVector = new PositionVector() { Coordinate = coordinate, Direction = Direction.North };
            Rover rover = new Rover() { currentPositionVector = positiontionVector };

            rover.currentPositionVector.Direction.Should().Be(Direction.North);
            rover.currentPositionVector.Coordinate.X.Should().Be(1);
            rover.currentPositionVector.Coordinate.Y.Should().Be(3);

        }
        [Fact]
        public void Rover_can_store_max_coordinate_to_rove_test()
        {
            Coordinate coordinate = new Coordinate() { X = 2, Y = 4 };
            Rover rover = new Rover() { MaxCoordinateToRove = coordinate };

            rover.MaxCoordinateToRove.X.Should().Be(2);
            rover.MaxCoordinateToRove.Y.Should().Be(4);

        }
        [Fact]
        public void Rover_can_rotate_left_test()
        {
            Coordinate maxCoordinateToRove = new Coordinate() { X = 2, Y = 4 };
            Coordinate initialCoordinate = new Coordinate() { X = 0, Y = 0 };
            PositionVector currentPositionVector = new PositionVector() { Coordinate = initialCoordinate, Direction = Direction.North };

            Rover rover = new Rover() { MaxCoordinateToRove = maxCoordinateToRove, currentPositionVector = currentPositionVector };

            rover.Rove('L');

            rover.currentPositionVector.Coordinate.X.Should().Be(0);
            rover.currentPositionVector.Coordinate.Y.Should().Be(0);
            rover.currentPositionVector.Direction.Should().Be(Direction.West);

        }
        [Fact]
        public void Rover_can_rotate_right_test()
        {
            Coordinate maxCoordinateToRove = new Coordinate() { X = 2, Y = 4 };
            Coordinate initialCoordinate = new Coordinate() { X = 0, Y = 0 };

            PositionVector currentPositionVector = new PositionVector() { Coordinate = initialCoordinate, Direction = Direction.North };

            Rover rover = new Rover() { MaxCoordinateToRove = maxCoordinateToRove, currentPositionVector = currentPositionVector };

            rover.Rove('R');

            rover.currentPositionVector.Coordinate.X.Should().Be(0);
            rover.currentPositionVector.Coordinate.Y.Should().Be(0);
            rover.currentPositionVector.Direction.Should().Be(Direction.East);

        }
        [Fact]
        public void Rover_can_step_forward_east_test()
        {
            Coordinate maxCoordinateToRove = new Coordinate() { X = 2, Y = 4 };
            Coordinate initialCoordinate = new Coordinate() { X = 0, Y = 0 };
            PositionVector currentPositionVector = new PositionVector() { Coordinate = initialCoordinate, Direction = Direction.East };

            Rover rover = new Rover() { MaxCoordinateToRove = maxCoordinateToRove, currentPositionVector = currentPositionVector };

            rover.Rove('F');

            rover.currentPositionVector.Coordinate.X.Should().Be(1);
            rover.currentPositionVector.Coordinate.Y.Should().Be(0);
            rover.currentPositionVector.Direction.Should().Be(Direction.East);

        }

        [Fact]
        public void Rover_can_step_forward_west_test()
        {
            Coordinate maxCoordinateToRove = new Coordinate() { X = 2, Y = 4 };
            Coordinate initialCoordinate = new Coordinate() { X = 2, Y = 1 };
            PositionVector currentPositionVector = new PositionVector() { Coordinate = initialCoordinate, Direction = Direction.West };

            Rover rover = new Rover() { MaxCoordinateToRove = maxCoordinateToRove, currentPositionVector = currentPositionVector };

            rover.Rove('F');

            rover.currentPositionVector.Coordinate.X.Should().Be(1);
            rover.currentPositionVector.Coordinate.Y.Should().Be(1);
            rover.currentPositionVector.Direction.Should().Be(Direction.West);

        }
        [Fact]
        public void Rover_can_step_forward_north_test()
        {
            Coordinate maxCoordinateToRove = new Coordinate() { X = 2, Y = 4 };
            Coordinate initialCoordinate = new Coordinate() { X = 2, Y = 1 };
            PositionVector currentPositionVector = new PositionVector() { Coordinate = initialCoordinate, Direction = Direction.North };

            Rover rover = new Rover() { MaxCoordinateToRove = maxCoordinateToRove, currentPositionVector = currentPositionVector };

            rover.Rove('F');

            rover.currentPositionVector.Coordinate.X.Should().Be(2);
            rover.currentPositionVector.Coordinate.Y.Should().Be(2);
            rover.currentPositionVector.Direction.Should().Be(Direction.North);

        }
        [Fact]
        public void Rover_can_step_forward_south_test()
        {
            Coordinate maxCoordinateToRove = new Coordinate() { X = 2, Y = 4 };
            Coordinate initialCoordinate = new Coordinate() { X = 2, Y = 1 };
            PositionVector currentPositionVector = new PositionVector() { Coordinate = initialCoordinate, Direction = Direction.South };

            Rover rover = new Rover() { MaxCoordinateToRove = maxCoordinateToRove, currentPositionVector = currentPositionVector };

            rover.Rove('F');

            rover.currentPositionVector.Coordinate.X.Should().Be(2);
            rover.currentPositionVector.Coordinate.Y.Should().Be(0);
            rover.currentPositionVector.Direction.Should().Be(Direction.South);

        }

        [Theory]
        [InlineData(0, 0, 2, 3, Direction.East, 'R', 0, 0, Direction.South)]
        [InlineData(1, 1, 2, 3, Direction.East, 'L', 1, 1, Direction.North)]

        public void Rover_can_rove_all_test(int initialX, int initialY, int maxX, int maxY, Direction initialDirection, char command, int expectedX, int expectedY, Direction expectedDirection)
        {
            Coordinate maxCoordinateToRove = new Coordinate() { X = maxX, Y = maxY };
            Coordinate initialCoordinate = new Coordinate() { X = initialX, Y = initialY };
            PositionVector currentPositionVector = new PositionVector() { Coordinate = initialCoordinate, Direction = initialDirection };

            Rover rover = new Rover() { MaxCoordinateToRove = maxCoordinateToRove, currentPositionVector = currentPositionVector };

            rover.Rove(command);

            rover.currentPositionVector.Coordinate.X.Should().Be(expectedX);
            rover.currentPositionVector.Coordinate.Y.Should().Be(expectedY);
            rover.currentPositionVector.Direction.Should().Be(expectedDirection);
        }
        [Fact]
        public void Rover_can_take_multiple_commands()
        {
            Coordinate maxCoordinateToRove = new Coordinate() { X = 2, Y = 4 };
            Coordinate initialCoordinate = new Coordinate() { X = 0, Y = 0 };
            PositionVector currentPositionVector = new PositionVector() { Coordinate = initialCoordinate, Direction = Direction.East };

            Rover rover = new Rover() { MaxCoordinateToRove = maxCoordinateToRove, currentPositionVector = currentPositionVector };

            RoveMultipleCommands("FFLFRR",ref rover);

            rover.currentPositionVector.Coordinate.X.Should().Be(2);
            rover.currentPositionVector.Coordinate.Y.Should().Be(1);
            rover.currentPositionVector.Direction.Should().Be(Direction.South);
        }


        public void RoveMultipleCommands(string commands, ref Rover rover)
        {
            foreach(char command in commands)
                rover.Rove(command);
        }
    }
}
