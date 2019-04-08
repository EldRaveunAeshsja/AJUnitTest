using System;
using System.Collections.Generic;
using System.Text;

namespace tpGarage
{
    public enum Types { Diesel, Essence, Electrique, Hybride };    

    class Moteurs
    {
        // attributs
        private int _puissance;

        // Constructeur
        public Moteurs(int puissance)
        {
            _puissance = puissance;
            
        }

        // accesseur
        public int Puissance { get => _puissance; set => _puissance = value; }

        // fonction
        public int getAllInfoMoteur()
        {
            return Puissance;
        }

    }
}
