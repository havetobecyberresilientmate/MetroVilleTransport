using System;

namespace MetrovilleTransport
{
    public abstract class Vehicule
    {
        private int numero;
        private int vitesse;
        private int capaciteMax;
        private Moteur moteur;

        public int Numero { get { return numero; } }

        public int Vitesse
        {
            get { return vitesse; }
            private set
            {
                if (value < 0 || value > 120)
                    throw new ArgumentOutOfRangeException("Vitesse", "La vitesse doit être entre 0 et 120 km/h.");
                vitesse = value;
            }
        }

        public Vehicule(int numero, int capaciteMax, int puissanceMoteur)
        {
            this.numero = numero;
            this.capaciteMax = capaciteMax;
            this.vitesse = 0;
            this.moteur = new Moteur(puissanceMoteur);
        }

        protected Moteur Moteur { get { return moteur; } }

        public void Accelerer(int increment)
        {
            int nouvelleVitesse = vitesse + increment;
            if (nouvelleVitesse > 120) nouvelleVitesse = 120;
            Vitesse = nouvelleVitesse;
        }

        public void Freiner(int decrement)
        {
            int nouvelleVitesse = vitesse - decrement;
            if (nouvelleVitesse < 0) nouvelleVitesse = 0;
            Vitesse = nouvelleVitesse;
        }

        public abstract void Demarrer();
        public abstract string GetTypeVehicule();

        public void AfficherEtat()
        {
            Console.WriteLine($"[{GetTypeVehicule()}] Véhicule n°{numero} | Vitesse : {vitesse} km/h | Moteur allumé : {moteur.EstAllume()}");
        }
    }
}
