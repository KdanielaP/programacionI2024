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
                while (true)
                {
                    Console.WriteLine("Ingresa la fila y columna (ejemplo: 1 2):");
                    string[] input = Console.ReadLine().Split();

                    if (input.Length != 2 || !int.TryParse(input[0], out row) || !int.TryParse(input[1], out col))
                    {
                        Console.WriteLine("Entrada inválida. Inténtalo de nuevo.");
                        continue;
                    }

                    row -= 1;
                    col -= 1;

                    if (row < 0 || row > 2 || col < 0 || col > 2 || board[row, col] != ' ')
                    {
                        Console.WriteLine("Celda ocupada o fuera de rango. Inténtalo de nuevo.");
                    }
                    else
                    {
                        break;
                    }
                }

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
            bool isWinner = false;

            // Verificar filas, columnas y diagonales
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                {
                    isWinner = true;
                    break;
                }

                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                {
                    isWinner = true;
                    break;
                }
            }

            if (!isWinner && ((board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)))
            {
                isWinner = true;
            }

            return isWinner;
        }

        static bool IsBoardFull()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
