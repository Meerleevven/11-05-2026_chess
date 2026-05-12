namespace chessLogic
{
    public class Bishop : Piece
    {
            public override PieceType Type => PieceType.bishop;
            public override Player Color { get; }

            private static readonly Direction[] dirs = new Direction[]
            {
                Direction.Northwest,
                Direction.Northeast,
                Direction.Southwest,
                Direction.Southeast
            };
            public Bishop(Player color)
            {
                Color = color;
            }
            public override Piece Copy()
            {
                Bishop copy = new Bishop(Color);
                copy.HasMoved = HasMoved;
                return copy;
            }

            public override IEnumerable<Move> GetMoves(Position from, Board board)
            {
                return MovePositionsInDirs(from, board, dirs).Select(to => new NormalMove(from, to));
            } 
    }
}
