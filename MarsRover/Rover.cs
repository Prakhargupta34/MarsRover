namespace MarsRover
{
    public class Rover
    {
        Action doAction = new Action();
        public Coordinate MaxCoordinateToRove { get; set; } = new Coordinate();
        public PositionVector currentPositionVector { get; set; } = new PositionVector();

        public void Rove(char c)
        {
            if (c == 'L' || c == 'R')
                currentPositionVector = doAction.Rotate(currentPositionVector,c);
            else if(c == 'F')
                currentPositionVector = doAction.StepForward(currentPositionVector,MaxCoordinateToRove);
        }
    }
}
