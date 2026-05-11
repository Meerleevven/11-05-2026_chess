using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using chessLogic;

namespace chessUI
{
    public static class Images
    {

        private static readonly Dictionary<PieceType, ImageSource> whiteSources = new()
        {
            { PieceType.pawn, LoadImage("Assets/pawnW.png") },
            { PieceType.rook, LoadImage("Assets/rookW.png") },
            { PieceType.knight, LoadImage("Assets/knightW.png") },
            { PieceType.bishop, LoadImage("Assets/bishopW.png") },
            { PieceType.queen, LoadImage("Assets/queenW.png") },
            { PieceType.king, LoadImage("Assets/kingW.png") }
        };

        private static readonly Dictionary<PieceType, ImageSource> blackSources = new()
        {
            { PieceType.pawn, LoadImage("Assets/pawnB.png") },
            { PieceType.rook, LoadImage("Assets/rookB.png") },
            { PieceType.knight, LoadImage("Assets/knightB.png") },
            { PieceType.bishop, LoadImage("Assets/bishopB.png") },
            { PieceType.queen, LoadImage("Assets/queenB.png") },
            { PieceType.king, LoadImage("Assets/kingB.png") }
        };
        private static ImageSource LoadImage(string filePath)
        {
            return new BitmapImage(new Uri(filePath, UriKind.Relative));
        }

        public static ImageSource GetImage(Player color, PieceType type)
        {
            return color switch
            {
                Player.White => whiteSources[type],
                Player.Black => blackSources[type],
                _ => null
            };
        }

        public static ImageSource GetImage(Piece piece)
        {
            if (piece == null)
            {
                return null;
            }
            return GetImage(piece.Color, piece.Type);
        }
    }
}
