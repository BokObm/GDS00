using System;
using System.Drawing;
using System.Windows.Forms;

namespace GEST_DE_STOCK
{

    public partial class cnxfrm : Form
    {
        private GEST_DE_STOCKEntities dB;
        BL.ConnexionCls C = new BL.ConnexionCls();
       
        public cnxfrm()
        {
            InitializeComponent();
            dB = new GEST_DE_STOCKEntities();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        string textobligatoire()
        {
            if (TextUser.Text == "" || TextUser.Text == "Identifiant")
            {
                return "Entrez votre Identifiant";
            }
            if (TextPassword.Text == "" || TextPassword.Text == "Mot de passe")
            {
                return "Entrez votre mot de passe";
            }
            return null;
        }


        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_button_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextUser_Enter(object sender, EventArgs e)
        {
            if (TextUser.Text == "")
            {
                TextUser.Text = "";
                TextUser.ForeColor = Color.DimGray;
            }
        }

        private void TextPassword_Enter(object sender, EventArgs e)
        {
            if (TextPassword.Text == "")
            {
                TextPassword.Text = "";
                TextPassword.UseSystemPasswordChar = false;
                TextPassword.PasswordChar = '*';
                TextPassword.ForeColor = Color.DimGray;
            }
        }

        private void TextUser_Leave(object sender, EventArgs e)
        {
           
        }

        private void TextPassword_Leave(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (textobligatoire() == null)
            {
                if(C.ConnexionValide( dB, TextUser.Text, TextPassword.Text)== true)
                {
                    new PL.MenuFrm().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Identifiant ou Mot de passe incorrect\nLa connexion a échoué", "Connexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(textobligatoire(), "Champ obligatoire", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void checkshowpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkshowpass.Checked)
            {
                TextPassword.PasswordChar = '\0';
            }else
            {
                TextPassword.PasswordChar = '*';
            }
        }

        private void SeConnecterButton_KeyDown(object sender, KeyEventArgs e)
        {
            
        }
    }
}

