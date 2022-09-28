using System;
using System.Collections.Generic;
using System.Text;

namespace MorpionObject
{
    public interface IMorpionGameState
    {
        Joueur PlayerTurn { get; set; }

        int TurnNumber { get; set; }

        int Winner { get; }
        void SetWinner(int joueurId);
        void NewTurn();
    }
}
