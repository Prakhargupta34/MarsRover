using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace MarsRover.Tests
{
    public class LocationVectorFixture
    {
        [Fact]
        void Can_store_coordinate()
        {
            Coordinate coordinate = new Coordinate() { X = 2, Y = 3 };
            PositionVector positionVector = new PositionVector() {Coordinate=coordinate };
            positionVector.Coordinate.X.Should().Be(2);
            positionVector.Coordinate.Y.Should().Be(3);
        }
        [Fact]
        void Can_store_direction()
        {
            PositionVector positionVector = new PositionVector() { Direction=Direction.East };
            positionVector.Direction.Should().Be(Direction.East);
        }
    }
}
