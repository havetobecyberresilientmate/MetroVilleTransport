using System;

namespace MetrovilleTransport
{
    class Program
    {
        static void Main(string[] args)
        {
            Bus bus1 = new Bus(1, 60, 300, true);
            Bus bus2 = new Bus(2, 60, 300, false);
            Tram tram3 = new Tram(3, 120, 450, 2);
            MetroAutomatique metro4 = new MetroAutomatique(4, 200, 500);

            Arret gare = new Arret("Gare Centrale");
            gare.AjouterPassagers(10);

            Arret universite = new Arret("Université");
            universite.AjouterPassagers(6);

            Arret marche = new Arret("Marché");
            marche.AjouterPassagers(8);

            Vehicule[] vehicules = { bus1, bus2, tram3, metro4 };
            Arret[] arrets = { gare, universite, marche };
            Ligne ligne42 = new Ligne(42, arrets, vehicules);

            Console.WriteLine($"\nPuissance maximale autorisée : {Moteur.GetPuissanceMax()} kW");

            ligne42.LancerService();

            ligne42.SimulerTour();

            Console.WriteLine("\n=== Test accélération et exception ===");
            bus1.Accelerer(40);
            Console.WriteLine($"Bus 1 accéléré à {bus1.Vitesse} km/h");

            try
            {
                bus1.Accelerer(200);
                bus1.Freiner(300);
                Console.WriteLine($"Bus 1 après freinage forcé : {bus1.Vitesse} km/h");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"ERREUR de vitesse : {ex.Message}");
            }

            Console.WriteLine("\n=== Position GPS ===");
            ILocalisable locBus1 = bus1;
            locBus1.ActualiserPosition(50.85, 4.35);
            Console.WriteLine($"Bus 1 - Latitude : {bus1.Latitude}, Longitude : {bus1.Longitude}");

            Console.WriteLine("\n=== Types de véhicules dans la flotte ===");
            foreach (Vehicule v in vehicules)
            {
                Console.WriteLine($"Véhicule n°{v.Numero} : {v.GetTypeVehicule()}");
            }

            Console.WriteLine("\n=== Détection du métro automatique ===");
            foreach (Vehicule v in vehicules)
            {
                if (v is MetroAutomatique metro)
                {
                    metro.SignalerIncident("Porte bloquée");
                }
            }
        }
    }
}
