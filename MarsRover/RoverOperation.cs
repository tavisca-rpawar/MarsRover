namespace MarsRover
{
    public class RoverOperation
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Directions direction { get; set; }
        public string moves { get; set; }
        public string finalPosition { get; set; }
        public enum Directions { N, S, E, W}
        private void TurnLeft()
        {
            switch (direction)
            {
                case Directions.N:
                    direction = Directions.W;
                    break;
                case Directions.S:
                    direction = Directions.E;
                    break;
                case Directions.E:
                    direction = Directions.N;
                    break;
                case Directions.W:
                    direction = Directions.S;
                    break;
                default:
                    break;
            }
        }
        private void TurnRight()
        {
            switch (direction)
            {
                case Directions.N:
                    direction = Directions.E;
                    break;
                case Directions.S:
                    direction = Directions.W;
                    break;
                case Directions.E:
                    direction = Directions.S;
                    break;
                case Directions.W:
                    direction = Directions.N;
                    break;
                default:
                    break;
            }
        }
        private void MoveStraight()
        {
            switch (direction)
            {
                case Directions.N: Y += 1;
                    break;
                case Directions.S: Y -= 1;
                    break;
                case Directions.E: X += 1;
                    break;
                case Directions.W: X -= 1;
                    break;
            }
        }
        public string Move(string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M': MoveStraight();
                        break;
                    case 'L': TurnLeft();
                        break;
                    case 'R': TurnRight();
                        break;
                }
            }
            finalPosition = "(" + X + "," + Y + "," + direction + ")";
            return finalPosition;
        }
    }
}
