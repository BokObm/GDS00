using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace GEST_DE_STOCK.PL
{
    
    public partial class AjouterClient : Form
    {
        private UserControl usclient;
        public AjouterClient(UserControl userC)
        {
            InitializeComponent();
            this.usclient = userC;
        }
        String Testobligatoire()
        {
            if (nomclient.Text == "")
            {
                return "Entrer le nom du client";
            }
            if (prenomclient.Text == "")
            {
                return "Entrer le prenom du client";
            }
            if (telclient.Text == "")
            {
                return "Entrer le tel du client";
            }
            if (emeilclient.Text == "")
            {
                return "Entrer l'email du client";
            }
            if (adresseclient.Text == "")
            {
                return "Enter l'adresse du client";
            }
            if (villeclient.Text == "")
            {
                return "entrer ville du client";
            }
            // verifier l'email
            if(emeilclient.Text != "")
            {
                try
                {
                    new MailAddress(emeilclient.Text);
                }catch(Exception e)
                {
                    return "Email invalid";
                }
            }
            return null;

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
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

        private void AjouterClient_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        public int IDselect;
        private void button1_Click(object sender, EventArgs e)
        {
            if (Testobligatoire() != null){
                MessageBox.Show(Testobligatoire(),"Obligatoire",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            if(labeltitre.Text == "Ajouter client")
            { 
                BL.ClientCls clclient = new BL.ClientCls();
                if (clclient.Ajouter_Client(nomclient.Text, prenomclient.Text, telclient.Text, emeilclient.Text, adresseclient.Text, villeclient.Text) == true)
                {
                    MessageBox.Show("client ajouter avec succes", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    (usclient as ClientFrm).ActualiserGrid();
                }
                else
                {
                    MessageBox.Show("Nom et prenom de client déja existe", "Ajouter", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                BL.ClientCls clclient = new BL.ClientCls();
                DialogResult R = MessageBox.Show("voulez-vous vraiment modifier ce client","Modification",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if(R == DialogResult.Yes)
                {
                    clclient.Modifier_client(IDselect, nomclient.Text, prenomclient.Text, telclient.Text, emeilclient.Text, adresseclient.Text, villeclient.Text);
                    (usclient as ClientFrm).ActualiserGrid();
                    MessageBox.Show("client modifier avec succes","Modification",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Modification est annulé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nomclient.Text = "";
            prenomclient.Text = "";
            telclient.Text = "";
            adresseclient.Text = "";
            emeilclient.Text = "";
            villeclient.Text = "";
        }
    }
}
