using System;

namespace MetrovilleTransport
{
    public class Tram : Vehicule
    {
        private int numeroRail;

        public Tram(int numero, int capacite, int puissanceMoteur, int numeroRail)
            : base(numero, capacite, puissanceMoteur)
        {
            this.numeroRail = numeroRail;
        }

        public override void Demarrer()
        {
            Moteur.Demarrer();
            Console.WriteLine($"Tram {Numero} sur rail {numeroRail} - prêt");
        }

        public override string GetTypeVehicule()
        {
            return "Tram";
        }
    }
}
