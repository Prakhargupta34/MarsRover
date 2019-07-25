namespace MarsRover
{
    class StepForwardSouth : IStepForward
    {
        public PositionVector StepForward(PositionVector currentPositionVector, Coordinate maxCoordinateToRove)
        {
            PositionVector updatedPositionVector = currentPositionVector;

            if (currentPositionVector.Coordinate.Y - 1 >= 0)
                updatedPositionVector.Coordinate.Y = currentPositionVector.Coordinate.Y - 1;
            return updatedPositionVector;

        }

    }
}
