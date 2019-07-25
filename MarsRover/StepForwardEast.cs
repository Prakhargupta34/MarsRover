using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class StepForwardEast : IStepForward
    {
        public PositionVector StepForward (PositionVector currentPositionVector, Coordinate maxCoordinateToRove)
        {
            PositionVector updatedPositionVector = currentPositionVector;

            if (currentPositionVector.Coordinate.X + 1 <= maxCoordinateToRove.X)
                updatedPositionVector.Coordinate.X = currentPositionVector.Coordinate.X + 1;

            return updatedPositionVector;

        }

    }
}
