using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TictactoeCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("yogesh", MarkType.X);
            Player player2 = new Player("shivam", MarkType.O);

            Player[] players = { player1, player2 };
            Board board = new Board();
            ResultAnalyzer resultAnalyzer = new ResultAnalyzer(board);

            Game game = new Game(players, board, resultAnalyzer);

            while (game.GetStatus() != ResultType.WIN || game.GetStatus() != ResultType.DRAW)
            {
                var currentPlayer = game.GetCurrentPlayer();
                Console.WriteLine(currentPlayer.Name);
                var location = Convert.ToInt32(Console.ReadLine());
                game.Play(location);

                Console.WriteLine(game.GetStatus());
                if (game.GetStatus() == ResultType.WIN)
                {
                    Console.WriteLine(currentPlayer.Name + " is winner");
                    break;
                }
                else if (game.GetStatus() == ResultType.DRAW)
                {
                    Console.WriteLine("draw");
                    break;
                }
            }


        }
    }
    
}
