using System;
using Xunit;

namespace TicTacToe.Tests
{
    public class BoardTest
    {
        [Fact]
        public void TestDimensions()
        {
            var board = new Board();
            Assert.Equal(3, board.Fields.Length);
            Assert.Equal(3, board.Fields[0].Length);
        }
    }
}
