using System;

namespace Totito
{
    class Program
    {
        static char[,] board = new char[3, 3] {
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' },
            { ' ', ' ', ' ' }
        };

        static char currentPlayer = 'X';

        static void Main()
        {
            while (true)
            {
                Console.Clear();
                DrawBoard();

                Console.WriteLine($"Turno del jugador {currentPlayer}:");

                int row, col;
                do
                {
                    Console.WriteLine("Ingresa la fila y columna (ejemplo: 1 2):");
                    string[] input = Console.ReadLine().Split();
                    row = int.Parse(input[0]) - 1;
                    col = int.Parse(input[1]) - 1;
                } while (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ');

                board[row, col] = currentPlayer;

                if (CheckWinner())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine($"El jugador {currentPlayer} ha ganado!");
                    break;
                }

                if (IsBoardFull())
                {
                    Console.Clear();
                    DrawBoard();
                    Console.WriteLine("¡Empate!");
                    break;
                }

                currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            }
        }

        static void DrawBoard()
        {
            Console.WriteLine("  1 2 3");
            for (int i = 0; i < 3; i++)
            {
                Console.Write((i + 1) + " ");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(board[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static bool CheckWinner()
        {
            // Verificar filas, columnas y diagonales
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                    return true;
                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                    return true;
            }

            if ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer))
                return true;

            return false;
        }

        static bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                        return false;
                }
            }
            return true;
        }
    }
}