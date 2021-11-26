using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeCore
{
    class Game
    {
        private Player[] _players;
        private Board _board;
        private ResultAnalyzer _resultAnalyzer;
        private ResultType _status;
        private Player _currentPlayer;
        private static int _count = 0;



        public Game(Player[] players, Board board, ResultAnalyzer resultAnalyzer)
        {
            this._players = players;
            this._board = board;
            this._resultAnalyzer = resultAnalyzer;
        }

        public Player GetCurrentPlayer()
        {
            if (_count % 2 == 0)
            {
                _currentPlayer = _players[0];
                _count++;
            }
            else
            {
                _currentPlayer = _players[1];
                _count++;
            }
            return _currentPlayer;
        }

        public void Play(int location)
        {
            _board.CellArray[location].Mark = _currentPlayer.Mark;

        }
        public ResultType GetStatus()
        {
            _status = _resultAnalyzer.Analyze();
            return _status;
        }
    }
}
