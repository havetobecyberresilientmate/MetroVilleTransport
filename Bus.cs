using System;

namespace MetrovilleTransport
{
    public class Bus : Vehicule, ILocalisable
    {
        private bool estEnZonePayante;
        private double latitude;
        private double longitude;

        public double Latitude { get { return latitude; } }
        public double Longitude { get { return longitude; } }

        public Bus(int numero, int capacite, int puissanceMoteur, bool estEnZonePayante)
            : base(numero, capacite, puissanceMoteur)
        {
            this.estEnZonePayante = estEnZonePayante;
            this.latitude = 0;
            this.longitude = 0;
        }

        public override void Demarrer()
        {
            Moteur.Demarrer();
            string zone = estEnZonePayante ? "payante" : "gratuite";
            Console.WriteLine($"Bus {Numero} prêt - zone {zone}");
        }

        public override string GetTypeVehicule()
        {
            return "Bus";
        }

        public void ActualiserPosition(double lat, double lon)
        {
            latitude = lat;
            longitude = lon;
        }
    }
}
