using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string whitePiecePosition, blackPiecePosition, movePosition;
            Console.WriteLine("Введите позицию белой фигуры");
            whitePiecePosition = Console.ReadLine();
            Console.WriteLine("Введите позицию черной фигуры");
            blackPiecePosition = Console.ReadLine();

            if (!IsValidPosition(whitePiecePosition) || !IsValidPosition(blackPiecePosition))
            {
                Console.WriteLine("Некорректные позиции фигур");
                Console.ReadLine();
                return;
            }

            if (whitePiecePosition == blackPiecePosition)
            {
                Console.WriteLine("Позиции фигур не должны совпадать");
                Console.ReadLine();
                return;
            }

            if (IsUnderAttack(whitePiecePosition, blackPiecePosition, "white"))
            {
                Console.WriteLine("Белая фигура находится под боем черной фигуры");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Введите позицию предполагаемого хода белой фигуры:");
            movePosition = Console.ReadLine();

            if (CanMove(whitePiecePosition, movePosition, "white") &&
                !IsUnderAttack(movePosition, blackPiecePosition, "black"))
            {
                // Перемещение фигуры
                whitePiecePosition = movePosition;
                Console.WriteLine($"Белая фигура переместилась на {whitePiecePosition}.");
            }
            else
            {
                Console.WriteLine("Белая фигура не может сделать этот ход или попадает под бой черной фигуры");
            }

            Console.WriteLine();
            Console.ReadLine();
        }

        static bool IsValidPosition(string position)
        {
            return position.Length == 2 &&
                   position[0] >= 'a' && position[0] <= 'h' &&
                   position[1] >= '1' && position[1] <= '8';
        }

        static bool CanMove(string from, string to, string pieceType)
        {
            int fromX, fromY, toX, toY;
            DecodePosition(from, out fromX, out fromY);
            DecodePosition(to, out toX, out toY);

            if (pieceType == "white" && Math.Abs(fromX - toX) <= 1 && Math.Abs(fromY - toY) <= 1)
                return true;

            if (pieceType == "white" && (fromX == toX || fromY == toY))
                return true;

            return false;
        }

        static bool IsUnderAttack(string piecePosition, string opponentPosition, string pieceType)
        {
            int pieceX, pieceY, opponentX, opponentY;
            DecodePosition(piecePosition, out pieceX, out pieceY);
            DecodePosition(opponentPosition, out opponentX, out opponentY);

            if (pieceType == "white" && Math.Abs(pieceX - opponentX) <= 1 && Math.Abs(pieceY - opponentY) <= 1)
                return true;

            if (pieceType == "white" && (pieceX == opponentX || pieceY == opponentY))
                return true;

            return false;
        }

        static void DecodePosition(string position, out int x, out int y)
        {
            x = position[0] - 'a' + 1;
            y = position[1] - '0';
        }
    }
}
