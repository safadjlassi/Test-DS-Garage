using BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        private Garage garage = new Garage("Tunis");

        public Form1()
        {
            InitializeComponent();
            btnAjouter.Click += btnAjouter_Click;
            btnCaracterestiques.Click += btnCaracteristiques_Click;
            rbVoiture.Checked = true;
        }

        private SubType TypeChoisi()
        {
            return rbMoto.Checked ? SubType.Moto : SubType.Voiture;
        }

        private void ViderInfos()
        {
            lblImmat.Text = "";
            lblAnnee.Text = "";
            lblType.Text = "";
        }

        // Remplit la ListBox selon Voiture / Moto
        private void ChargerListe()
        {
            lstAutos.Items.Clear();
            foreach (Automobile a in garage.AfficherAutomobiles(TypeChoisi()))
                lstAutos.Items.Add(a.Immatriculation);
            ViderInfos();
        }

        private void rbVoiture_CheckedChanged(object sender, EventArgs e)
        {
            ChargerListe();
        }

        private void lstAutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAutos.SelectedItem == null) return;

            Automobile a = garage.GetAuto(lstAutos.SelectedItem.ToString());
            lblImmat.Text = a.Immatriculation;
            lblAnnee.Text = a.Annee.ToString();
            lblType.Text = (a is Moto) ? "Moto" : "Voiture";
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bouton Ajouter clique");

            if (rbVoiture.Checked)
                new NouvelleVoiture(garage).ShowDialog();
            else
                new NouvelleMoto(garage).ShowDialog();

            ChargerListe();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (lstAutos.SelectedItem == null)
            {
                MessageBox.Show("Selectionnez une automobile");
                return;
            }
            MessageBox.Show(garage.DeleteAuto(lstAutos.SelectedItem.ToString()));
            ChargerListe();
        }

        private void btnCaracteristiques_Click(object sender, EventArgs e)
        {
            if (lstAutos.SelectedItem == null)
            {
                MessageBox.Show("Selectionnez une automobile");
                return;
            }
            Automobile a = garage.GetAuto(lstAutos.SelectedItem.ToString());

            if (a is Moto)
                new MotoInfos((Moto)a).ShowDialog();
            else
                new VoitureInfos((Voiture)a).ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}