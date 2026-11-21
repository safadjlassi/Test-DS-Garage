using BLL;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class MotoInfos : Form
    {
        public MotoInfos(Moto m)
        {
            InitializeComponent();
            lblImmat.Text = m.Immatriculation;

            lvInfos.View = View.Details;
            lvInfos.Columns.Add("Cylindre", 100);
            lvInfos.Columns.Add("Vitesse Max", 100);

            ListViewItem ligne = new ListViewItem(m.Cylindre.ToString());
            ligne.SubItems.Add(m.VitesseMax.ToString());
            lvInfos.Items.Add(ligne);
        }
    }
}