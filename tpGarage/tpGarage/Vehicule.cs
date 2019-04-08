using System;
using System.Collections.Generic;
using System.Text;


namespace tpGarage
{
    abstract class Vehicule
    {
        //attributs
        private int _idVehicule;
        private static int _incrementIdVehicule;
        private string _nom;
        private int _prix;
        private string _marque;
        private Moteurs _moteur;
        private List<Option> _option;


        // accesseurs
        public int IdVehicule { get => _idVehicule; set => _idVehicule = value; }
        public static int IncrementIdVehicule { get => _incrementIdVehicule; set => _incrementIdVehicule = value; }
        public string Nom { get => _nom; set => _nom = value; }
        public int Prix { get => _prix; set => _prix = value; }
        public string Marque { get => _marque; set => _marque = value; }
        public Moteurs Moteur { get => _moteur; set => _moteur = value; }
        internal List<Option> Option { get => _option; set => _option = value; }

        // constructeur
        public Vehicule()
        {
            Console.WriteLine("nom du vehicule: ");
            _nom = Console.ReadLine();

            Console.WriteLine("prix du vehicule: ");
            _prix = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("Marque du vehicule: ");
            _marque = Console.ReadLine();

            // ------------------------------ > TODO

            //Console.WriteLine("Moteur du vehicule: ");
            //_moteur = GetMoteur();

            // Console.WriteLine("option du vehicule: ");
            // _option = Console.ReadLine();         

        }

        public Vehicule(int idVehicule, string nom, int prix , string marque /**, Moteurs moteur, List<Option> option**/)
        {
            _idVehicule = idVehicule;
            _nom = nom;
            _prix = prix;
            _marque = marque;
            //_moteur = moteur;
            //_option = option;
        }

        // Fonction 
        public void GetAllInfos()
        {

        }

        public static void AfficherInfo(Vehicule vehicule, Voiture voiture)
        {
            Console.WriteLine("");
            Console.WriteLine("Fiche du vehicule");
            Console.WriteLine("---------------------------");
            Console.WriteLine("Marque du vehicule: " + vehicule.Marque);
            Console.WriteLine("Nom du vehicule: " + vehicule.Nom);
            Console.WriteLine("Prix du vehicule: " + vehicule.Prix);
            Console.WriteLine("Taille de coffre du vehicule: " + voiture.TailleCoffre);
            Console.WriteLine("NombrePorte du vehicule: " + voiture.NombrePorte);
            Console.WriteLine("NombreSiege du vehicule: " + voiture.NombreSiege);
            Console.WriteLine("puissance du vehicule : " + voiture.Puissance + " chevaux");
            Console.WriteLine("---------------------------");
            //Console.WriteLine(vehicule.);
            //Console.WriteLine(Option);

        }

        public void AddOption()
        {

        }

        public void GetMarque()
        {

        }

        public string GetMoteur()
        {
            return "";   
        }

        public void GetOption()
        {

        }

        public void GetPrixHT()
        {

        }

        public void GetTaxe()
        {

        }

        
        public abstract int CalculerTaxe();
       
    }
}
