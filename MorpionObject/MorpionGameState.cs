using System;
using System.Collections.Generic;
using System.Text;

namespace MorpionObject
{
    public class MorpionGameState : IMorpionGameState
    {
        public Joueur PlayerTurn { get; set; }

        public int TurnNumber { get; set; }

        public int Winner { get; set; }

        private IMorpionGameState _gameState;

        public Joueur _joueur1;

        public Joueur _joueur2;
        public MorpionGameState()
        {

        }
        public void ChangePlayerTurn()
        {
            if (_gameState.TurnNumber % 2 == 0)
            {
                this._gameState.PlayerTurn = _joueur1;
            }
            else
            {
                this._gameState.PlayerTurn = _joueur2;
            }
        }
        public int ChangeTurnNumber()
        {
            _gameState.TurnNumber++;

            return _gameState.TurnNumber;
        }
        
        public void SetWinner(int joueurId)
        {
            this.Winner = joueurId;
        }
        public void NewTurn() { }


    }
}
