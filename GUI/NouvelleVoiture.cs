using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class NouvelleVoiture : Form
    {
        private Garage garage;

        public NouvelleVoiture(Garage g)
        {
            InitializeComponent();
            garage = g;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            int annee;
            if (!int.TryParse(txtAnnee.Text, out annee))
            {
                MessageBox.Show("Annee invalide");
                return;
            }
            if (txtImmat.Text.Trim() == "")
            {
                MessageBox.Show("Immatriculation obligatoire");
                return;
            }

            Voiture v = new Voiture(annee, txtImmat.Text, txtCouleur.Text,
                                    txtMarque.Text, txtType.Text);
            MessageBox.Show(garage.AddAuto(v));
            this.Close();
        }

        // Methodes vides creees par Visual Studio (le Designer en a besoin)
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void NouvelleVoiture_Load(object sender, EventArgs e) { }
        private void txtAnnee_TextChanged(object sender, EventArgs e) { }
        private void txtImmat_TextChanged(object sender, EventArgs e) { }
        private void txtCouleur_TextChanged(object sender, EventArgs e) { }
        private void txtMarque_TextChanged(object sender, EventArgs e) { }
        private void txtType_TextChanged(object sender, EventArgs e) { }
    }
}