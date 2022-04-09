using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GEST_DE_STOCK.PL
{
    public partial class AjouterFournisseur : Form
    {
        private UserControl usFournisseur;
        public AjouterFournisseur()
        {
            InitializeComponent();
        }
        String Testobligatoire()
        {
            if (idfournisseur.Text == "")
            {
                return "Entrer l'identificateur du fournisseur";
            }
            if (nomfournisseur.Text == "")
            {
                return "Entrer le nom du fournisseur";
            }
            if (adressefournisseur.Text == "")
            {
                return "Entrer le prenom du fournisseur";
            }
            if (emailfourniseur.Text == "")
            {
                return "Entrer le tel du fournisseur";
            }
            if (emailfourniseur.Text != "")
            {
                try
                {
                    new MailAddress(emailfourniseur.Text);
                }
                catch (Exception e)
                {
                    return "Email invalid";
                }
            }
            return null;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            idfournisseur.Text = "";
            nomfournisseur.Text = "";
            adressefournisseur.Text = "";
            emailfourniseur.Text = "";
        }
        public int IDselect;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Testobligatoire() != null)
            {
                MessageBox.Show(Testobligatoire(), "Obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            if (labeltitrefour.Text == "Ajouter fouenisseur")
            {
                BL.FornissuerCls clfournisseur = new BL.FornissuerCls();
                if (clfournisseur.Ajouter_Fournisseur(nomfournisseur.Text, adressefournisseur.Text, emailfourniseur.Text) == true)
                {
                    MessageBox.Show("fournisseur ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usFournisseur as FournisseurFrm).ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("Nom de fournisseur déja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BL.FornissuerCls clfournisseur = new BL.FornissuerCls();
                DialogResult R = MessageBox.Show("voulez-vous vraiment modifier ce fournisseur", "Modification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    clfournisseur.Modifier_fournisseur(IDselect, nomfournisseur.Text, adressefournisseur.Text, emailfourniseur.Text);
                    (usFournisseur as ClientFrm).ActualiserGrid();
                    MessageBox.Show("fournisseur modifier avec succes", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void labeltitrefour_Click(object sender, EventArgs e)
        {

        }
    }
}
