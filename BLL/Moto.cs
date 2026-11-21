
using System;

namespace BLL
{
    public class Moto : Automobile
    {
        private int cylindre;
        private int vitesseMax;

        public int Cylindre
        {
            get { return cylindre; }
            set { cylindre = value; }
        }

        public int VitesseMax
        {
            get { return vitesseMax; }
            set { vitesseMax = value; }
        }

        public Moto() : base()
        {
            cylindre = 0;
            vitesseMax = 0;
        }

        public Moto(int annee, string immatriculation,
                    int cylindre, int vitesseMax)
            : base(annee, immatriculation)
        {
            this.cylindre = cylindre;
            this.vitesseMax = vitesseMax;
        }

        public override void afficher()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return base.ToString()
                + ", Cylindre : " + Cylindre
                + ", Vitesse maximale : " + VitesseMax;
        }
    }
}
