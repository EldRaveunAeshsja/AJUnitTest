using System;
using System.Collections.Generic;
using System.Text;

namespace tpGarage
{
    class Camion : Vehicule
    {
        // attributs
        private int _nombreEssieux;
        private int _poidChargement;
        private int _volumeChargement;


        // accesseurs
        public int NombreEssieux { get => _nombreEssieux; set => _nombreEssieux = value; }
        public int PoidChargement { get => _poidChargement; set => _poidChargement = value; }
        public int VolumeChargement { get => _volumeChargement; set => _volumeChargement = value; }

        // Constructeurs
        public Camion()
        {
            Console.WriteLine("nombre d'essieux: ");
            _nombreEssieux = Int32.Parse(Console.ReadLine());

            Console.WriteLine("masse maximale de chargement: ");
            _poidChargement = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Volume maximale de chargement: ");
            _volumeChargement = Int32.Parse(Console.ReadLine());
        }

        public Camion(int nombreEssieux, int poidChargement, int volumeChargement)
        {
            _nombreEssieux = nombreEssieux;
            _poidChargement = poidChargement;
            _volumeChargement = volumeChargement;
        }

        public Camion(int idVehicule, string nom, int prix) //: base(idVehicule, nom, prix)
        {
        }


        //public Camion(int nombreEssieux, int poidChargement, int volumeChargement) : base(idVehicule, nom, prix)
        //{
        //}

        public override int CalculerTaxe()
        {
            return 0;
        }
    }
}
