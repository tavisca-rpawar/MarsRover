using System;
using Xunit;

namespace MarsRover.Test
{
    public class RoverTest
    {
        
        [Theory]
        [InlineData("(0,1,e)", "MML", "(2,1,N)")]
        [InlineData("(0,0,N)", "MmM", "(0,3,N)")]
        [InlineData("(10,5,n)", "MMLMrmML", "(9,9,W)")]
        public void rover_test(string position, string moves, string expected)
        {
            RoverPositionAllocator rover = new RoverPositionAllocator();
            rover.InitialPosition(position);
            string actual = rover.Moves(moves);
            actual.Equals(expected);
        }
        [Theory]
        [InlineData("mkl", "Invalid Input")]
        [InlineData("mmmOOl", "Invalid Input")]
        public void rover_moves_validator_test(string moves, string expected)
        {
            RoverPositionAllocator rover = new RoverPositionAllocator();
            string actual = rover.Moves(moves);
            actual.Equals(expected);
        }
    }
}
