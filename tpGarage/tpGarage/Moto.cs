using System;
using System.Collections.Generic;
using System.Text;

namespace tpGarage
{
    class Moto : Vehicule
    {
        // attributs 
        private string _cylindree;

        // accesseur
        public string Cylindree { get => _cylindree; set => _cylindree = value; }

        // Constructeur
        public Moto()
        {
            Console.WriteLine("Cylindré de la motheu heing");
            _cylindree = Console.ReadLine();
        }

        public Moto(string cylindree)
        {
            _cylindree = cylindree;
        }
    }
}
