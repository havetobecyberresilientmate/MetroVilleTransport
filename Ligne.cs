using System;

namespace MetrovilleTransport
{
    public class Ligne
    {
        private int numeroLigne;
        private Arret[] arrets;
        private Vehicule[] vehicules;

        public Ligne(int numeroLigne, Arret[] arrets, Vehicule[] vehicules)
        {
            this.numeroLigne = numeroLigne;
            this.arrets = arrets;
            this.vehicules = vehicules;
        }

        public void LancerService()
        {
            Console.WriteLine($"\n=== Lancement du service - Ligne {numeroLigne} ===");
            foreach (Vehicule v in vehicules)
            {
                v.Demarrer();
            }
        }

        public void SimulerTour()
        {
            Console.WriteLine($"\n=== Simulation d'un tour - Ligne {numeroLigne} ===");
            foreach (Vehicule v in vehicules)
            {
                Console.WriteLine($"\n-- {v.GetTypeVehicule()} n°{v.Numero} en service --");
                foreach (Arret a in arrets)
                {
                    int montes = a.FaireMonter(5);
                    Console.WriteLine($"  Arrêt [{a.Nom}] : {montes} passager(s) monté(s), {a.GetPassagersEnAttente()} en attente");
                    v.AfficherEtat();
                }
            }
        }
    }
}
