namespace MarsRover
{
    class StepForwardNorth : IStepForward
    {
        public PositionVector StepForward(PositionVector currentPositionVector, Coordinate maxCoordinateToRove)
        {
            PositionVector updatedPositionVector = currentPositionVector;

            if (currentPositionVector.Coordinate.Y + 1 <= maxCoordinateToRove.Y)
                updatedPositionVector.Coordinate.Y = currentPositionVector.Coordinate.Y + 1; 
            return updatedPositionVector;

        }
    }
}
