using System;
using System.Collections.Generic;
using System.Text;

namespace MorpionObject
{
    public interface IBoard
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>-1 if invalid column or row, -2 if spot already take, else 0</returns>
        int FillSpot(string token, int row, int column);

        /// <summary>
        /// Clean the Board
        /// </summary>
        void CleanBoard();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="token"></param>
        /// <returns></returns>
        bool WinPlayer(string token);

        /// <summary>
        /// Function that verify if the case choosed by the user is empty or full 
        /// </summary>
        int[] EmptySpots();

        /// <summary>
        /// Display the board
        /// </summary>
        void Display();
    
    }
}
