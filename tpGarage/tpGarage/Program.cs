using System;

namespace tpGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            Voiture voiture = new Voiture();
            Vehicule.AfficherInfo(voiture, voiture);

            Console.ReadLine();
            
            
        }
    }
}
