using System;
using System.Linq;

namespace _3.Recursion___EightQueens
{
    class EightQueens
    {
        static void Main(string[] args)
        {
            int size = 7;
            SolveQueensProblem(new bool[size, size], new int[size, size], 0);
            Console.WriteLine(count);
        }
        static int count = 0;
        static void SolveQueensProblem(bool[,] board, int[,] occupied, int columnIndex)
        {
            if (columnIndex==board.GetLength(0))
            {
                count++;
                return;
            }

            for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
            {
                if (occupied[rowIndex, columnIndex] == 0)
                {

                    board[rowIndex, columnIndex] = true; //postavqme carica
                    MarkOccupied(occupied, +1, rowIndex, columnIndex); //Markirame occupied
                    SolveQueensProblem(board, occupied, columnIndex + 1); //izvikvame rekursivno, za da markirame occupied poziciite
                    board[rowIndex, columnIndex] = false; //mahame caricata ot kudeto sme q slojili
                    MarkOccupied(occupied, -1, rowIndex, columnIndex); //Razmarkirame occupied

                }
            }
        }

        static void MarkOccupied(int[,] occupied, int value, int row, int column)
        {
            for (int i = 0; i < occupied.GetLength(0); i++)
            {
                occupied[i, column] += value;
                occupied[row, i] += value;

                if (column + i < occupied.GetLength(0) && row + i < occupied.GetLength(0))
                {
                    occupied[row + i, column + i] += value;
                }
                if (column + i < occupied.GetLength(0) && row - i >= 0)
                {
                    occupied[row - i, column + i] += value;
                }
            }

        }
    }
}
