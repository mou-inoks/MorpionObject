using System;
using System.Collections.Generic;
using System.Text;

namespace MorpionObject
{
    public class Board : IBoard
    {
        private string[,] board;
        public void CleanBoard()
        {
            throw new NotImplementedException();
        }

        public int[] EmptySpots()
        {
            int nbEmptySpots = 0;
            for(int y = 0; y < 3; y++)
            {
                for(int z = 0; z < 3; z++)
                {
                    if (board[y, z] == " ")
                    {
                        nbEmptySpots++;
                    }
                }
            }

            int[] tabEmptySpots = new int[nbEmptySpots];

            int cpt = 0;
            for (int y = 0; y < 3; y++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (board[y, z] == " ")
                    {
                        tabEmptySpots[cpt] = y * 3 + z;
                        cpt++;
                    }
                }
            }
            return tabEmptySpots;

        }

        public void Display()
        {

            Console.WriteLine();
            Console.WriteLine("0    |1     |2 ");
            Console.WriteLine($"  {board[0, 0]}  |  {board[0, 1]}   |  {board[0, 2]}");
            Console.WriteLine("-----+------+----");
            Console.WriteLine("3    |4     |5");
            Console.WriteLine($" {board[1, 0]}   |  {board[1, 1]}   |   {board[1, 2]}");
            Console.WriteLine("     |      | ");
            Console.WriteLine("-----+------+----");
            Console.WriteLine("6    |7     |8");
            Console.WriteLine($"  {board[2, 0]}  |   {board[2, 1]}  |   {board[2, 2]}");
        }

        public int FillSpot(string token, int row, int column)
        {
            if(row > 3 || row < 0 || column < 0 || column > 3)
            {
                return -1;
            }
            else if (board[row, column] != " ")
            {
                return -2;
            }
            else
            {
                return 0;
            }
        }

        public bool WinPlayer(string token)
        {
            return (board[0, 0] == token && board[1, 0] == token && board[2, 0] == token ||
           board[0, 1] == token && board[1, 1] == token && board[2, 1] == token ||
           board[0, 2] == token && board[1, 2] == token && board[2, 2] == token ||
           board[0, 0] == token && board[0, 1] == token && board[0, 2] == token ||
           board[1, 0] == token && board[1, 1] == token && board[1, 2] == token ||
           board[2, 0] == token && board[2, 1] == token && board[2, 2] == token ||
           board[0, 0] == token && board[1, 1] == token && board[2, 2] == token ||
           board[2, 0] == token && board[1, 1] == token && board[0, 2] == token);
        }
    }

    //Formule pour convertir la case donnée en ligne et colomne 
    
    //string placed = board[row, column] = token;
}