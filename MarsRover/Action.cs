using System.Collections.Generic;

namespace MarsRover
{
    public class Action
    {

        public Dictionary<Direction, IStepForward> StepForwardDict = new Dictionary<Direction, IStepForward>()
        {
            {Direction.East , new StepForwardEast() },
            {Direction.West , new StepForwardWest() },
            {Direction.North , new StepForwardNorth() },
            {Direction.South , new StepForwardSouth() },
            {Direction.NorthEast , new StepForwardNorthEast() },
            {Direction.SouthWest , new StepForwardSouthWest() },
            {Direction.NorthWest , new StepForwardNorthWest() },
            {Direction.SouthEast , new StepForwardSouthEast() }

        };
        public Dictionary<char, IRotate> RotateDict = new Dictionary<char, IRotate>()
        {
            {'L' , new RotateLeft() },
            {'R' , new RotateRight() },

        };
        public PositionVector StepForward(PositionVector currentPositionVector, Coordinate maxCoordinateToRove)
        {
            PositionVector updatedPositionVector = currentPositionVector;

            updatedPositionVector = StepForwardDict[currentPositionVector.Direction].StepForward(currentPositionVector, maxCoordinateToRove);

            return updatedPositionVector;
        }

        public PositionVector Rotate(PositionVector currentPositionVector, char orientation)
        {
            PositionVector updatedPositionVector = currentPositionVector;

            updatedPositionVector = RotateDict[orientation].Rotate(currentPositionVector);

            return updatedPositionVector;
        }
    }
}
