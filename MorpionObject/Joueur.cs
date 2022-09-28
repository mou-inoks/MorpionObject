using System;
using System.Collections.Generic;
using System.Text;

namespace MorpionObject
{
    public class Joueur
    {
        public string Pseudo { get; set; }

        public int Token { get; set; }
        public int Id { get; }

        public int Type { get; }

        public Joueur(string pseudo, int token, int id, int type)
        {
            Pseudo = pseudo;
            Token = token;
            Id = id;
            Type = type;
        }
    }
}
