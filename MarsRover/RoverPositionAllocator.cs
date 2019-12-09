using System;
using static MarsRover.RoverOperation;

namespace MarsRover
{
    public class RoverPositionAllocator
    {
        RoverOperation rover = new RoverOperation();
        public void InitialPosition(string position)
        {
            position = position.ToUpper().Trim('(', ')');
            string[] initialPosition = position.Split(',');
            if(Validators.ValidateIniilaPosition(initialPosition) == true)
            {
                rover.X = Int32.Parse(initialPosition[0]);
                rover.Y = Int32.Parse(initialPosition[1]);
                rover.direction = (Directions)Enum.Parse(typeof(Directions), initialPosition[2]);
            }
        }
        public string Moves(string moves)
        {
            moves = moves.Trim().ToUpper();
            if (Validators.ValidateMoves(moves) == true)
            {
                var finalPosition = rover.Move(moves);
                return finalPosition;
            }
            return "Invalid Input";
        }
    }
}
