using System;
using System.Collections.Generic;
using System.Text;


namespace MorpionObject
{
    public class Morpion : IMorpion
    {
        private IBoard _morpionBoard;

        private MorpionGameState _gameState;

        public int setTokenOnBoard = 0;


        /// <summary>
        ///  Represent a full game of Morpion
        /// </summary>
        public void StartGame()
        {
            bool quitGmae = false;

            while (quitGmae)
            {
                Console.WriteLine("BIENVENU DANS LE JEU DU MORPION ");

                Console.WriteLine();

                Console.WriteLine("Choisissez le mode de jeu. ");

                Console.WriteLine("1: Joueur VS Joueur");
                Console.WriteLine("2: Joueur VS Machine");

                int gameChoice = Convert.ToInt32(Console.ReadLine());

                if(gameChoice == 1)
                {
                    
                }
                else
                {

                }

            }


        }


        public void MultiPlayer()
        {
            Console.Clear();
            Console.WriteLine("Veuillez choisir un pseudo. ");

            Console.WriteLine();
            Console.WriteLine("Pseudo : ");

            _gameState._joueur1.Pseudo = Console.ReadLine();

            Console.WriteLine("Choisissez un signe ");

            string signChoice = "";

            while (signChoice != "x" || signChoice != "o")
            {
                signChoice = Console.ReadLine();

                if (signChoice == "x")
                {

                }
                else if (signChoice == "o")
                {

                }
                else
                {
                    Console.WriteLine("S'il vous plait choisissez un signe valable. ");
                }
            }

            _gameState._joueur1.Token = Console.ReadLine("")

            if(_gameState._joueur1.Token == (int)Token.O)
            {
                _gameState._joueur2.Token = (int)Token.X;
            }
            else 


        }

        /// <summary>
        /// Represent a turn of Morpion
        /// </summary>
        public void PlayTurn()
        {

            // Récupere l'id du joueur qui doit jouer 
            var playerId = _gameState.PlayerTurn;

            //Une fois qu'on sait qui doit jouer, on récupere son type, si c'est un humain ou une machine 
            if (_gameState.PlayerTurn.Type == (int)JoueurTypeEnum.Humain)
            {
                HumanPlayTurn();
            }
            else
            {
                CpuPlayTurn();
            }

            //Maintenant qu'on sait si c'est un humain ou un robot, on entre l'action 
            

             
        }


        /// <summary>
        /// Represent a CPU Turn 
        /// </summary>
        private void CpuPlayTurn()
        {
            //Tant qu'il répond faux, on recommence
            //Créer un nombre random 
            //Utiliser ce nombre random pour choisir la case 
            //Convertir le chiffre en ligne et colomne 
            //Vérifier qu'il n'y a rien sur la case 

            int placeOnBoardBot = -1;

            while (placeOnBoardBot == -2 || placeOnBoardBot == -1)
            {
                Random num = new Random(); //<----- génère un chiffre random 

                int number = num.Next(0, 9); //<---- place le chiffre random généré dans une variable number 

                int row = (number - (number % 3)) / 3; //<--- Convertion en ligne 
                int column = number % 3;    //<--- Convertion en colomne 

                var token = Convert.ToString(this._gameState.PlayerTurn); //<--- Récupère le token 

                placeOnBoardBot = _morpionBoard.FillSpot(token, row, column); //<--- Place sur la grille
                                                                                 
            }
            
            
        }

        /// <summary>
        /// Represent a Human Play
        /// </summary>
        private void HumanPlayTurn()
        {
            setTokenOnBoard = Convert.ToInt32(Console.ReadLine());
            
            int row = (setTokenOnBoard - (setTokenOnBoard % 3)) / 3;
            int column = setTokenOnBoard % 3;

            var token = Convert.ToString(this._gameState.PlayerTurn);
            _morpionBoard.FillSpot(token, row, column);
        }
        /// <summary>
        /// Represent a common play (whatever it's human or cpu)
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns>0 if everything is fine, other number otherwise</returns>
        private int CommonTurn(int row, int column)
        {

            return 0;
        }
    }
}
