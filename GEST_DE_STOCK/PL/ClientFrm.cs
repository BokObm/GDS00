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
    public partial class ClientFrm : UserControl
    {
        private static ClientFrm ClientUser;
        private GEST_DE_STOCKEntities db;
        public static ClientFrm Instance
        {
            get
            {
                if (ClientUser == null)
                {
                    ClientUser = new ClientFrm();
                }
                return ClientUser;
            }
        }
        public ClientFrm()
        {
            InitializeComponent();
            db = new GEST_DE_STOCKEntities();
            rechercheclient.Enabled = false;
        }
        public void ActualiserGrid()
        {
            db = new GEST_DE_STOCKEntities();
            dataGridView1.Rows.Clear();
            foreach(var S in db.Client)
            {
                dataGridView1.Rows.Add(false,S.ID_client,S.Nom_client,S.Prenom_client,S.Tel_client,S.Email_client,S.Adresse_client,S.Ville_client);
            }

        }
        // verifier combien de ligne est selectionner 
        public String selectverify()
        {
            int nmbrligneselcted = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                {
                    nmbrligneselcted++;
                }
            }
            if(nmbrligneselcted == 0)
            {
                return "selectionner le client que vous voulez modifier";
            }
            if (nmbrligneselcted>1)
            {
                return "selectionner seulement 1 seul client pour modidfier";
            }
            return null;
        }


        private void ClientFrm_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PL.AjouterClient ajoutecli = new PL.AjouterClient(this);
            ajoutecli.ShowDialog();
        }
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            PL.AjouterClient ajoutecli = new PL.AjouterClient(this);
            if (selectverify() == null)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                    {
                        ajoutecli.IDselect = (int)dataGridView1.Rows[i].Cells[1].Value;
                        ajoutecli.nomclient.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
                        ajoutecli.prenomclient.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
                        ajoutecli.telclient.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
                        ajoutecli.adresseclient.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
                        ajoutecli.villeclient.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    }
                }
                ajoutecli.labeltitre.Text = "Modifier client";
                ajoutecli.buttonactualiser.Visible = false; 
                ajoutecli.ShowDialog();
            }
            else
            {
                MessageBox.Show(selectverify(),"Modification",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            BL.ClientCls clclient = new BL.ClientCls();
            //pour supprimer tout les client ajouter
            int select = 0;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if(select == 0)
            {
                MessageBox.Show("aucun client selectionner","suppression",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if(select > 1)
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(R == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if ((bool)dataGridView1.Rows[i].Cells[0].Value == true)
                        {
                            clclient.supprimer_client(int.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    ActualiserGrid();
                    MessageBox.Show("Suppression avec succes","suppression",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Suppression annulé", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            db = new GEST_DE_STOCKEntities();
            var listerecherche = db.Client.ToList();
            if(combochercheclient.Text != "")
            {
                switch (combochercheclient.Text)
                {
                    case "Nom Client":
                        listerecherche = (List<Client>)listerecherche.Where(s => s.Nom_client.IndexOf(rechercheclient.Text, StringComparison.CurrentCultureIgnoreCase) != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                    case "Prénom Client":
                        listerecherche = (List<Client>)listerecherche.Where(s => s.Prenom_client.IndexOf(rechercheclient.Text, StringComparison.CurrentCultureIgnoreCase) != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                    case "N° Téléphone":
                        listerecherche = (List<Client>)listerecherche.Where(s => s.Tel_client != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                    case "Email Client":
                        listerecherche = (List<Client>)listerecherche.Where(s => s.Email_client.IndexOf(rechercheclient.Text, StringComparison.CurrentCultureIgnoreCase) != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                    case "Adresse Client":
                        listerecherche = (List<Client>)listerecherche.Where(s => s.Adresse_client.IndexOf(rechercheclient.Text, StringComparison.CurrentCultureIgnoreCase) != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                    case "Ville Client":
                        listerecherche = (List<Client>)listerecherche.Where(s => s.Ville_client.IndexOf(rechercheclient.Text, StringComparison.CurrentCultureIgnoreCase) != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;


                }
            }
            dataGridView1.Rows.Clear();
            //ajouter liste recherche dans data grid view
            foreach(var l in listerecherche)
            {
                dataGridView1.Rows.Add(false, l.ID_client, l.Nom_client, l.Prenom_client, l.Tel_client, l.Email_client, l.Adresse_client, l.Ville_client);
            }
        }

        private void combochercheclient_SelectedIndexChanged(object sender, EventArgs e)
        {
            rechercheclient.Enabled = true;
            rechercheclient.Text = "";

        }
    }
}