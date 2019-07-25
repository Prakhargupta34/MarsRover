namespace MarsRover
{
    class RotateRight : IRotate
    {
        public PositionVector Rotate(PositionVector currentPositionVector)
        {
            PositionVector updatedLocationVector = currentPositionVector;

            if ((int)updatedLocationVector.Direction == 3)
                updatedLocationVector.Direction = (Direction)0;
            else
                updatedLocationVector.Direction = (Direction)updatedLocationVector.Direction + 1;

            return updatedLocationVector;
        }
    }
}
