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
        public void Rover_Test_Should_Return_Final_Position(string position, string moves, string expected)
        {
            RoverPositionAllocator rover = new RoverPositionAllocator();
            rover.InitialPosition(position);
            string actual = rover.Moves(moves);
            actual.Equals(expected);
        }

        [Fact]
        public void Validate_InitialPositin_Test_Should_Return_False_For_Inavalid_InitialPosition()
        {
            string[] initialPosition = { "1", "2", "3" };
            bool actual = Validators.ValidateIniilaPosition(initialPosition);
            bool expected = false;
            actual.Equals(expected);
        }
        [Theory]
        [InlineData("MMLR", true)]
        [InlineData("MnM", false)]
        [InlineData("MMLMrmkldL", false)]
        public void Validator_Moves_Test_Should_Return_False_For_Inavalid_Rover_Moves(string moves, bool expected)
        {
            bool actual = Validators.ValidateMoves(moves);
            actual.Equals(expected);
        }
    }
}

