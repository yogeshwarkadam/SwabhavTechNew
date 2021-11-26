using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeCore
{
    public class Board
    {
        private Cell[] _cellArray = new Cell[9];
        private const int Array_Size = 9;

        public Board()
        {
            for (int i = 0; i < _cellArray.Length; i++)
            {
                _cellArray[i] = new Cell();
            }
        }

        public Cell[] CellArray
        {
            get { return _cellArray; }
        }

        public bool IsBoardFull()
        {
            int count = 0;
            for (int i = 0; i < _cellArray.Length; i++)
            {
                if (_cellArray[i].Mark != MarkType.Empty)
                {
                    count += 1;
                }
            }

            if (count == Array_Size)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool IsBoardEmpty()
        {
            int count = 0;
            for (int i = 0; i < _cellArray.Length; i++)
            {
                if (_cellArray[i].Mark == MarkType.Empty)
                {
                    count += 1;
                }
            }

            if (count == Array_Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void MarkBoard(MarkType inputMarkType, int location)
        {
            _cellArray[location].Mark = inputMarkType;
        }
    }
}
