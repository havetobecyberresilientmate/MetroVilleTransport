using System;

namespace MetrovilleTransport
{
    public class Arret
    {
        private string nom;
        private int passagersEnAttente;

        public string Nom { get { return nom; } }

        public Arret(string nom)
        {
            this.nom = nom;
            this.passagersEnAttente = 0;
        }

        public void AjouterPassagers(int nb)
        {
            if (nb < 0)
                throw new ArgumentException("Le nombre de passagers ne peut pas être négatif.");
            passagersEnAttente += nb;
        }

        public int FaireMonter(int nb)
        {
            int montent = Math.Min(nb, passagersEnAttente);
            passagersEnAttente -= montent;
            return montent;
        }

        public int GetPassagersEnAttente()
        {
            return passagersEnAttente;
        }
    }
}
