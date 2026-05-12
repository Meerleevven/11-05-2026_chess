using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessLogic
{
    public class GameState
    {
        public Board Board { get; private set; }
        public Player CurrentPlayer { get; private set; }
        public GameState(Player player, Board board)
        {
            Board = board;
            CurrentPlayer = player;
        }

        public IEnumerable<Move> GetLegalMovesForPieces(Position pos)
        {
            if (Board.IsEmpty(pos) || Board[pos].Color != CurrentPlayer)
            {
                return Enumerable.Empty<Move>();
            }

            Piece piece = Board[pos];
            return piece.GetMoves(pos, Board);
        }

        public void MakeMove(Move move)
        {
            move.Execute(Board);
            CurrentPlayer = CurrentPlayer.Opponent();
        }
    }
}
