using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public interface IStepForward
    {
        PositionVector StepForward(PositionVector currentPositionVector, Coordinate maxCoordinateToRove);
    }
}
