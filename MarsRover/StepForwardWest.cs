namespace MarsRover
{
    class StepForwardWest : IStepForward
    {
        public PositionVector StepForward(PositionVector currentPositionVector, Coordinate maxCoordinateToRove)
        {
            PositionVector updatedPositionVector = currentPositionVector;

            if (currentPositionVector.Coordinate.X - 1 >= 0)
                updatedPositionVector.Coordinate.X = currentPositionVector.Coordinate.X - 1;
            return updatedPositionVector;

        }
    }
}
