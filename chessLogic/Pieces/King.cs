using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessLogic
{
    public class King : Piece
    {
        public override PieceType Type => PieceType.king;
        public override Player Color { get; }
        public King(Player color)
        {
            Color = color;
        }
        public override Piece Copy()
        {
            King copy = new King(Color);
            copy.HasMoved = HasMoved;
            return copy;
        }
    }
}
