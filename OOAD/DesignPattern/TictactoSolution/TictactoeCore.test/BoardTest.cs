using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TictactoeCore;

namespace TictactoeCore.test
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void CheckBoardIsFull()
        {
            Board board = new Board();

            for (int i = 0; i < board.CellArray.Length; i++)
            {
                board.MarkBoard(MarkType.X, i);
            }

            var fullStatus = board.IsBoardFull();
            Assert.IsTrue(fullStatus == true);
        }

        [TestMethod]
        public void CheckBoardIsEmpty()
        {
            Board board = new Board();
           // board.CellArray[0].Mark = MarkType.X;
            var emptyStatus = board.IsBoardEmpty();
            Assert.IsTrue(emptyStatus == true);
        }
        [TestMethod]
        public void MarkBoardAtSpecificCellLocation_WithX_or_WithO()
        {
            Board board = new Board();
            var cellLocation = 8;
            board.MarkBoard(MarkType.X, cellLocation);
            var cellStatus = board.CellArray[cellLocation].Mark;
            Assert.IsTrue(cellStatus == MarkType.X);
        }
    }
}
