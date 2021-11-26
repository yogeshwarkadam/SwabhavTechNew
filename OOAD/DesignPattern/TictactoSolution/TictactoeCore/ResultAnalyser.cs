using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeCore
{
    public class ResultAnalyzer
    {
        private Board _board;
        private const int BOARD_SIZE = 9;

        public ResultAnalyzer(Board board)
        {
            this._board = board;
        }

        public ResultType Analyze()
        {
            if (CheckRow() || CheckColumn() || CheckDiagonal())
            {
                return ResultType.WIN;
            }
            else if (!_board.IsBoardFull())
            {
                return ResultType.NO_RESULT;
            }
            else
            {
                return ResultType.DRAW;
            }
        }
        private bool CheckRow()
        {
            var cellArray = _board.CellArray;
            var column = 3;

            for (int i = 0; i < BOARD_SIZE; i += column)
            {
                if (cellArray[i].Mark == cellArray[i + 1].Mark
                    && cellArray[i + 1].Mark == cellArray[i + 2].Mark
                    && cellArray[i].Mark != MarkType.Empty
                    && cellArray[i + 1].Mark != MarkType.Empty
                    && cellArray[i + 2].Mark != MarkType.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        private bool CheckColumn()
        {
            var cellArray = _board.CellArray;
            var row = 3;

            for (int i = 0; i < row; i++)
            {
                if (cellArray[i].Mark == cellArray[i + row].Mark
                    && cellArray[i + row].Mark == cellArray[i + row * 2].Mark
                    && cellArray[i].Mark != MarkType.Empty
                    && cellArray[i + row].Mark != MarkType.Empty
                    && cellArray[i + row * 2].Mark != MarkType.Empty)
                {
                    return true;
                }
            }
            return false;
        }
        private bool CheckDiagonal()
        {
            var cellArray = _board.CellArray;
            if ((cellArray[0].Mark == cellArray[4].Mark && cellArray[4].Mark == cellArray[8].Mark)
                || (cellArray[2].Mark == cellArray[4].Mark && cellArray[4].Mark == cellArray[6].Mark)
                && cellArray[0].Mark != MarkType.Empty
                && cellArray[4].Mark != MarkType.Empty
                && cellArray[8].Mark != MarkType.Empty
                && cellArray[2].Mark != MarkType.Empty
                && cellArray[4].Mark != MarkType.Empty
                && cellArray[6].Mark != MarkType.Empty
                )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
