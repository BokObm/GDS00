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
    public partial class MenuFrm : Form
    {
        public MenuFrm()
        {
            InitializeComponent();
            InsidePanel.Controls.Add(VenteFrm.Instance);
            VenteFrm.Instance.Dock = DockStyle.Fill;
            VenteFrm.Instance.BringToFront();
            this.StartPosition = FormStartPosition.CenterScreen;
            ProduitsButton2.Hide();
            CommandeButton2.Hide();
            LivraisonButton2.Hide();
            FournisseursButton2.Hide();
            ClientsButton2.Hide();


        }

        private void MenuFrm_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (InsidePanel.Controls.Contains(VenteFrm.Instance) == false)
            {
                InsidePanel.Controls.Add(VenteFrm.Instance);
                VenteFrm.Instance.Dock = DockStyle.Fill;
                VenteFrm.Instance.BringToFront();
            }
            else
            {
                VenteFrm.Instance.BringToFront();
            }
            VenteButton2.Show();
            ProduitsButton2.Hide();
            CommandeButton2.Hide();
            LivraisonButton2.Hide();
            FournisseursButton2.Hide();
            ClientsButton2.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void gunaShadowPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Date_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Date.Text = DateTime.Now.ToShortDateString();
            Time.Text = DateTime.Now.ToShortTimeString();
        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Paint(object sender, PaintEventArgs e)
        {
            timer1.Start();
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void InsidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CommandeButton_Click(object sender, EventArgs e)
        {
            if (InsidePanel.Controls.Contains(CommandeFrm.Instance) == false)
            {
                InsidePanel.Controls.Add(CommandeFrm.Instance);
                CommandeFrm.Instance.Dock = DockStyle.Fill;
                CommandeFrm.Instance.BringToFront();
            }
            else
            {
                CommandeFrm.Instance.BringToFront();
            }
            CommandeButton2.Show();
            VenteButton2.Hide();
            ProduitsButton2.Hide();
            LivraisonButton2.Hide();
            FournisseursButton2.Hide();
            ClientsButton2.Hide();
        }

        private void VenteButton2_Click(object sender, EventArgs e)
        {

        }

        private void ProduitsButton2_Click(object sender, EventArgs e)
        {

        }

        private void ProductsButton_Click(object sender, EventArgs e)
        {
            if (InsidePanel.Controls.Contains(ProduitFrm.Instance) == false)
            {
                InsidePanel.Controls.Add(ProduitFrm.Instance);
                ProduitFrm.Instance.Dock = DockStyle.Fill;
                ProduitFrm.Instance.BringToFront();
            }
            else
            {
                ProduitFrm.Instance.BringToFront();
            }
            CommandeButton2.Hide();
            VenteButton2.Hide();
            ProduitsButton2.Show();
            LivraisonButton2.Hide();
            FournisseursButton2.Hide();
            ClientsButton2.Hide();
        }

        private void CommandeButton2_Click(object sender, EventArgs e)
        {

        }

        private void LivraisonButton2_Click(object sender, EventArgs e)
        {

        }

        private void LivraisonButton_Click(object sender, EventArgs e)
        {
            if (InsidePanel.Controls.Contains(LivraisonFrm.Instance) == false)
            {
                InsidePanel.Controls.Add(LivraisonFrm.Instance);
                LivraisonFrm.Instance.Dock = DockStyle.Fill;
                LivraisonFrm.Instance.BringToFront();
            }
            else
            {
                LivraisonFrm.Instance.BringToFront();
            }
            CommandeButton2.Hide();
            VenteButton2.Hide();
            ProduitsButton2.Hide();
            LivraisonButton2.Show();
            FournisseursButton2.Hide();
            ClientsButton2.Hide();
        }

        private void ClientButton_Click(object sender, EventArgs e)
        {
            if (InsidePanel.Controls.Contains(ClientFrm.Instance) == false)
            {
                InsidePanel.Controls.Add(ClientFrm.Instance);
                ClientFrm.Instance.Dock = DockStyle.Fill;
                ClientFrm.Instance.BringToFront();
            }
            else
            {
                ClientFrm.Instance.BringToFront();
            }
            CommandeButton2.Hide();
            VenteButton2.Hide();
            ProduitsButton2.Hide();
            LivraisonButton2.Hide();
            FournisseursButton2.Hide();
            ClientsButton2.Show();
        }

        private void FournisseursButton_Click(object sender, EventArgs e)
        {
            if (InsidePanel.Controls.Contains(FournisseurFrm.Instance) == false)
            {
                InsidePanel.Controls.Add(FournisseurFrm.Instance);
                FournisseurFrm.Instance.Dock = DockStyle.Fill;
                FournisseurFrm.Instance.BringToFront();
            }
            else
            {
                FournisseurFrm.Instance.BringToFront();
            }
            CommandeButton2.Hide();
            VenteButton2.Hide();
            ProduitsButton2.Hide();
            LivraisonButton2.Hide();
            FournisseursButton2.Show();
            ClientsButton2.Hide();

        }
    }
}
