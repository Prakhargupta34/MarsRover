namespace MarsRover
{
    class StepForwardNorth : IStepForward
    {
        public PositionVector StepForward(PositionVector currentPositionVector, Coordinate maxCoordinateToRove)
        {
            PositionVector updatedPositionVector = currentPositionVector;

            
            updatedPositionVector.Coordinate.Y = currentPositionVector.Coordinate.Y + 1;

            if (updatedPositionVector.Coordinate.CheckBounds(maxCoordinateToRove) == false)
                return updatedPositionVector;
            return currentPositionVector;

        }
    }
}
