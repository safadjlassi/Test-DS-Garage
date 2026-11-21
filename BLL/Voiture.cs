
using System;

namespace BLL
{
    public class Voiture : Automobile
    {
        private string couleur;
        private string marque;
        private string typeV;

        public string Couleur
        {
            get { return couleur; }
            set { couleur = value; }
        }

        public string Marque
        {
            get { return marque; }
            set { marque = value; }
        }

        public string TypeV
        {
            get { return typeV; }
            set { typeV = value; }
        }

        public Voiture() : base()
        {
            couleur = "";
            marque = "";
            typeV = "";
        }

        public Voiture(int annee, string immatriculation,
                       string couleur, string marque, string typeV)
            : base(annee, immatriculation)
        {
            this.couleur = couleur;
            this.marque = marque;
            this.typeV = typeV;
        }

        public override void afficher()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString()
                + ", Couleur : " + Couleur
                + ", Marque : " + Marque
                + ", Type : " + TypeV;
        }
    }
}
