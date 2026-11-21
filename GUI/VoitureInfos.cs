using BLL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class VoitureInfos : Form
    {
        public VoitureInfos(Voiture v)
        {
            InitializeComponent();
            lblImmat.Text = v.Immatriculation;

            lvInfos.View = View.Details;
            lvInfos.Columns.Add("Couleur", 100);
            lvInfos.Columns.Add("Marque", 100);
            lvInfos.Columns.Add("Type", 100);

            ListViewItem ligne = new ListViewItem(v.Couleur);
            ligne.SubItems.Add(v.Marque);
            ligne.SubItems.Add(v.TypeV);
            lvInfos.Items.Add(ligne);
        }
    }
}