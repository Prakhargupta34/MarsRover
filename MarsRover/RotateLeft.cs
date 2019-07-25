using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    class RotateLeft : IRotate
    {
        public PositionVector Rotate(PositionVector currentPositionVector)
        {
            PositionVector updatedLocationVector = currentPositionVector;

            if ((int)updatedLocationVector.Direction == 0)
                updatedLocationVector.Direction = (Direction)3;
            else
                updatedLocationVector.Direction = (Direction)updatedLocationVector.Direction - 1;

            return updatedLocationVector;
        }
    }
}
