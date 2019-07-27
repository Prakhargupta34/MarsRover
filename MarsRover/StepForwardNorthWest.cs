namespace MarsRover
{
    public class StepForwardNorthWest : IStepForward
    {
        public PositionVector StepForward(PositionVector currentPositionVector, Coordinate maxCoordinateToRove)
        {
            PositionVector updatedPositionVector = currentPositionVector;

          
                updatedPositionVector.Coordinate.X = currentPositionVector.Coordinate.X - 1;
                updatedPositionVector.Coordinate.Y = currentPositionVector.Coordinate.Y + 1;

            if (updatedPositionVector.Coordinate.CheckBounds(maxCoordinateToRove) == false)
                return updatedPositionVector;
            return currentPositionVector;

        }
    }
}
