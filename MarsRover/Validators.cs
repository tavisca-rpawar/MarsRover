using System;
using static MarsRover.RoverOperation;

namespace MarsRover
{
    public class Validators
    {
        public static bool ValidateIniilaPosition(string[] position)
        {
            if (position.Length == 3 && Enum.IsDefined(typeof(Directions), position[2]))
            {
                return true;
            }
            return false;
        }
        public static bool ValidateMoves(string moves)
        {
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'M':
                    case 'L':
                    case 'R':
                        break;
                    default:
                        return false;
                }
            }
            return true;
        }
    }
}
