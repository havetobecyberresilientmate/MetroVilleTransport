using System;

namespace MetrovilleTransport
{
    public class MetroAutomatique : Vehicule
    {
        private bool modeAutonome;

        public MetroAutomatique(int numero, int capacite, int puissanceMoteur)
            : base(numero, capacite, puissanceMoteur)
        {
            this.modeAutonome = true;
        }

        public override void Demarrer()
        {
            Console.WriteLine($"Metro {Numero} - activation du pilote automatique");
        }

        public override string GetTypeVehicule()
        {
            return "Metro Automatique";
        }

        public void SignalerIncident(string description)
        {
            Console.WriteLine($"[INCIDENT Metro {Numero}] : {description}");
        }
    }
}
