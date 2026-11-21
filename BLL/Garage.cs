using System.Collections.Generic;

namespace BLL
{
    public class Garage : IGarage
    {
        // Attributs
        private string adresse;
        private List<Automobile> autos;

        // Propriete
        public string Adresse
        {
            get { return adresse; }
            set { adresse = value; }
        }

        // Constructeur sans parametres
        public Garage()
        {
            adresse = "";
            autos = new List<Automobile>();
        }

        // Constructeur avec parametres
        public Garage(string adresse)
        {
            this.adresse = adresse;
            autos = new List<Automobile>();
        }

        // Retourne la position de l'auto dans la liste, ou -1 si elle n'existe pas
        public int GetIndexAuto(Automobile a1)
        {
            for (int i = 0; i < autos.Count; i++)
            {
                if (autos[i].Immatriculation == a1.Immatriculation)
                    return i;
            }
            return -1;
        }

        // Cherche une auto par son immatriculation
        public Automobile GetAuto(string immatriculation)
        {
            foreach (Automobile a in autos)
            {
                if (a.Immatriculation == immatriculation)
                    return a;
            }
            return null;
        }

        public string AddAuto(Automobile au)
        {
            if (GetIndexAuto(au) != -1)
                return "Cette automobile existe deja";

            autos.Add(au);
            return "Ajout reussi";
        }

        public string UpdateAuto(Automobile au)
        {
            int index = GetIndexAuto(au);
            if (index == -1)
                return "Automobile introuvable";

            autos[index] = au;
            return "Modification reussie";
        }

        public string DeleteAuto(string immatriculation)
        {
            Automobile a = GetAuto(immatriculation);
            if (a == null)
                return "Automobile introuvable";

            autos.Remove(a);
            return "Suppression reussie";
        }

        // Retourne seulement les Voitures ou seulement les Motos
        public List<Automobile> AfficherAutomobiles(SubType soustype)
        {
            List<Automobile> resultat = new List<Automobile>();

            foreach (Automobile a in autos)
            {
                if (soustype == SubType.Voiture && a is Voiture)
                    resultat.Add(a);
                else if (soustype == SubType.Moto && a is Moto)
                    resultat.Add(a);
            }
            return resultat;
        }
    }
}