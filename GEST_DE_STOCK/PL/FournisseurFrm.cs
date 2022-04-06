using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEST_DE_STOCK.PL
{
    public partial class FournisseurFrm : UserControl
    {
        private static FournisseurFrm FournisseurUser;
        public static FournisseurFrm Instance
        {
            get
            {
                if (FournisseurUser == null)
                {
                    FournisseurUser = new FournisseurFrm();
                }
                return FournisseurUser;
            }
        }
        public FournisseurFrm()
        {
            InitializeComponent();
        }

        private void FournisseurFrm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PL.AjouterFournisseur ajoutefourn = new AjouterFournisseur();
            ajoutefourn.ShowDialog();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            PL.AjouterFournisseur ajoutefourn = new PL.AjouterFournisseur();
            ajoutefourn.labeltitrefour.Text = "Modifier fournisseur";
            ajoutefourn.buttonactualiserfour.Visible = false;
            ajoutefourn.ShowDialog();
        }
    }
}
