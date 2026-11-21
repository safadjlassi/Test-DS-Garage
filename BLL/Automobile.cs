using System;

namespace BLL
{
    public class Automobile
    {
        // Attributs
        private int annee;
        private string immatriculation;

        // Proprietes
        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public string Immatriculation
        {
            get { return immatriculation; }
            set { immatriculation = value; }
        }
        public Automobile() { }
       
       

        // Constructeur avec parametres
        public Automobile(int annee, string immatriculation)
        {
            this.annee = annee;
            this.immatriculation = immatriculation;
        }

        // Methode afficher
        public virtual void afficher()
        {
            Console.WriteLine(ToString());
        }

        // Methode ToString
        public override string ToString()
        {
            return "Annee : " + Annee
                + ", Immatriculation : " + Immatriculation;
        }
    }
}