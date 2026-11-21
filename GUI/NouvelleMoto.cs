using System;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class NouvelleMoto : Form
    {
        private Garage garage;

        public NouvelleMoto(Garage g)
        {
            InitializeComponent();
            garage = g;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int annee, cylindre, vitesse;
            if (!int.TryParse(txtAnnee.Text, out annee) ||
                !int.TryParse(txtCylindre.Text, out cylindre) ||
                !int.TryParse(txtVitesse.Text, out vitesse))
            {
                MessageBox.Show("Annee, cylindre et vitesse doivent etre des nombres");
                return;
            }
            if (txtImmat.Text.Trim() == "")
            {
                MessageBox.Show("Immatriculation obligatoire");
                return;
            }

            Moto m = new Moto(annee, txtImmat.Text, cylindre, vitesse);
            MessageBox.Show(garage.AddAuto(m));
            this.Close();
        }
    }
}