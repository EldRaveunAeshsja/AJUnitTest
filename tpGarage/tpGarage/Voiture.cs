using System;
using System.Collections.Generic;
using System.Text;

namespace tpGarage
{
    class Voiture : Vehicule
    {
        // attributs
        private int _puissance; 
        private int _nombrePorte;
        private int _nombreSiege;
        private int _tailleCoffre;

        // accesseur
        public int Puissance { get => _puissance; set => _puissance = value; }
        public int NombrePorte { get => _nombrePorte; set => _nombrePorte = value; }
        public int NombreSiege { get => _nombreSiege; set => _nombreSiege = value; }
        public int TailleCoffre { get => _tailleCoffre; set => _tailleCoffre = value; }

        // Constructeur
        public Voiture()
        {
            Console.WriteLine("puissance de la voiture: ");
            _puissance = Int32.Parse(Console.ReadLine());

            Console.WriteLine("nombre de porte de la voiture: ");
            _nombrePorte = Int32.Parse(Console.ReadLine());

            Console.WriteLine("nombre de siege de la voiture: ");
            _nombreSiege = Int32.Parse(Console.ReadLine());

            Console.WriteLine("taille du coffre de la voiture: ");
            _tailleCoffre = Int32.Parse(Console.ReadLine());
        }

        public Voiture(int puissance, int nombrePorte, int nombreSiege, int tailleCoffre)
        {
            Puissance = puissance;
            NombrePorte = nombrePorte;
            NombreSiege = nombreSiege;
            TailleCoffre = tailleCoffre;
        }

        public override int CalculerTaxe()
        {
            return 0;  
        } 

    }
}
