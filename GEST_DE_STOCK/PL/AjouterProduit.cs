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
    public partial class AjouterProduit : Form
    {
        private UserControl usProduit;
        public AjouterProduit()
        {
            InitializeComponent();
        }
        String Testobligatoire()
        {
            if (idproduit.Text == "")
            {
                return "Entrer l'identificateur du Produit";
            }
            if (nomproduit.Text == "")
            {
                return "Entrer le nom du produit";
            }
            if (dateproduit.Text == "")
            {
                return "Entrer la date d'entrée du produit";
            }
            if (qteproduit.Text == "")
            {
                return "Entrer la quantitée du produit";
            }
            if (prixproduit.Text == "")
            {
                return "Entrer le prix du produit";
            }
            return null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!char.IsDigit(c))
            {
                e.Handled = true;
            }
        }
        public int IDselect;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Testobligatoire() != null)
            {
                MessageBox.Show(Testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (labeltitrepro.Text == "Ajouter fouenisseur")
            {
                BL.ProduitCls clproduit = new BL.ProduitCls();
                if (clproduit.Ajouter_produit(nomproduit.Text, dateproduit.Text, qteproduit.Text ,prixproduit.Text) == true)
                {
                    MessageBox.Show("fournisseur ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usProduit as FournisseurFrm).ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("Nom de fournisseur déja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BL.ProduitCls clfournisseur = new BL.ProduitCls();
                DialogResult R = MessageBox.Show("voulez-vous vraiment modifier ce fournisseur", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    clfournisseur.Modifier_produit(IDselect, nomproduit.Text, dateproduit.Text, qteproduit.Text, prixproduit.Text);
                    (usProduit as ClientFrm).ActualiserGrid();
                    MessageBox.Show("Produit modifier avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void AjouterProduit_Load(object sender, EventArgs e)
        {

        }

        private void qteproduit_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            idproduit.Text = "";
            nomproduit.Text = "";
            dateproduit.Text = "";
            qteproduit.Text = "";
            prixproduit.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
