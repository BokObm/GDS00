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
        private GEST_DE_STOCKEntities db;
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
            db = new GEST_DE_STOCKEntities();
            recherchefournisseur.Enabled = false;
        }
        public void ActualiserGrid()
        {
            db = new GEST_DE_STOCKEntities();
            dataGridViewfourn.Rows.Clear();
            foreach (var S in db.Fournisseur)
            {
                dataGridViewfourn.Rows.Add(false, S.ID_fournisseur, S.Nom_fournisseur, S.Mail_fournisseur, S.Adresse_fournisseur);
            }
        }
        public String selectverify()
        {
            int nmbrligneselcted = 0;
            for (int i = 0; i < dataGridViewfourn.Rows.Count; i++)
            {
                if ((bool)dataGridViewfourn.Rows[i].Cells[0].Value == true)
                {
                    nmbrligneselcted++;
                }
            }
            if (nmbrligneselcted == 0)
            {
                return "selectionner le client que vous voulez modifier";
            }
            if (nmbrligneselcted > 1)
            {
                return "selectionner seulement 1 seul client pour modidfier";
            }
            return null;
        }

        private void FournisseurFrm_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PL.AjouterFournisseur ajoutefourn = new AjouterFournisseur();
            ajoutefourn.ShowDialog();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            PL.AjouterFournisseur ajoutefourn = new PL.AjouterFournisseur();
            if (selectverify() == null)
            {
                for (int i = 0; i < dataGridViewfourn.Rows.Count; i++)
                {
                    if ((bool)dataGridViewfourn.Rows[i].Cells[0].Value == true)
                    {
                        ajoutefourn.IDselect = (int)dataGridViewfourn.Rows[i].Cells[1].Value;
                        ajoutefourn.nomfournisseur.Text = dataGridViewfourn.Rows[i].Cells[2].Value.ToString();
                        ajoutefourn.emailfourniseur.Text = dataGridViewfourn.Rows[i].Cells[3].Value.ToString();
                        ajoutefourn.adressefournisseur.Text = dataGridViewfourn.Rows[i].Cells[4].Value.ToString();
                    }
                }
                ajoutefourn.labeltitrefour.Text = "Modifier fournisseur";
                ajoutefourn.buttonactualiserfour.Visible = false;
                ajoutefourn.ShowDialog();
            }
            else
            {
                MessageBox.Show(selectverify(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            BL.FornissuerCls clfourniseeur = new BL.FornissuerCls();
            //pour supprimer tout les fournisseurs ajouter
            int select = 0;
            for (int i = 0; i < dataGridViewfourn.Rows.Count; i++)
            {
                if ((bool)dataGridViewfourn.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun fournisseur selectionner", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (select > 1)
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewfourn.Rows.Count; i++)
                    {
                        if ((bool)dataGridViewfourn.Rows[i].Cells[0].Value == true)
                        {
                            clfourniseeur.supprimer_fournisseur(int.Parse(dataGridViewfourn.Rows[i].Cells[1].Value.ToString()));
                        }
                    }
                    ActualiserGrid();
                    MessageBox.Show("Suppression avec succes", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
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
            var listerecherche = db.Fournisseur.ToList();
            if (comborecherche.Text != "")
            {
                switch (comborecherche.Text)
                {
                    case "Nom Fournisseur":
                        listerecherche = (List<Fournisseur>)listerecherche.Where(s => s.Nom_fournisseur.IndexOf(recherchefournisseur.Text, StringComparison.CurrentCultureIgnoreCase) != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                    case "Adresse Fournisseur":
                        listerecherche = (List<Fournisseur>)listerecherche.Where(s => s.Adresse_fournisseur.IndexOf(recherchefournisseur.Text, StringComparison.CurrentCultureIgnoreCase) != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                    case "Email Fournisseur":
                        listerecherche = (List<Fournisseur>)listerecherche.Where(s => s.Mail_fournisseur.IndexOf(recherchefournisseur.Text, StringComparison.CurrentCultureIgnoreCase) != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                }
            }
            dataGridViewfourn.Rows.Clear();
            //ajouter liste recherche dans data grid view
            foreach (var l in listerecherche)
            {
                dataGridViewfourn.Rows.Add(false, l.ID_fournisseur, l.Nom_fournisseur, l.Adresse_fournisseur, l.Mail_fournisseur);
            }
        }

        private void comborecherche_SelectedIndexChanged(object sender, EventArgs e)
        {
            recherchefournisseur.Enabled = true;
            recherchefournisseur.Text = "";
        }
    }
}
