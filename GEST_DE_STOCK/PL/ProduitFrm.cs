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
    public partial class ProduitFrm : UserControl
    {
        private static ProduitFrm ProduitUser;
        private GEST_DE_STOCKEntities db;
        public static ProduitFrm Instance
        {
            get
            {
                if (ProduitUser == null)
                {
                    ProduitUser = new ProduitFrm();
                }
                return ProduitUser;
            }
        }
        public ProduitFrm()
        {
            InitializeComponent();
            db = new GEST_DE_STOCKEntities();

        }
        public void ActualiserGrid()
        {
            db = new GEST_DE_STOCKEntities();
            dataGridViewproduit.Rows.Clear();
            foreach (var S in db.Produit)
            {
                dataGridViewproduit.Rows.Add(false, S.ID_produit, S.Nom_produit, S.Date_entrée_stock, S.Qte_produit,S.Prix_produit);
            }
        }
        public String selectverify()
        {
            int nmbrligneselcted = 0;
            for (int i = 0; i < dataGridViewproduit.Rows.Count; i++)
            {
                if ((bool)dataGridViewproduit.Rows[i].Cells[0].Value == true)
                {
                    nmbrligneselcted++;
                }
            }
            if (nmbrligneselcted == 0)
            {
                return "selectionner le produit que vous voulez modifier";
            }
            if (nmbrligneselcted > 1)
            {
                return "selectionner seulement 1 seul produit pour modidfier";
            }
            return null;
        }
        private void ProduitFrm_Load(object sender, EventArgs e)
        {
            ActualiserGrid();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PL.AjouterProduit ajoutepro = new AjouterProduit();
            ajoutepro.ShowDialog();
        }
        private void gunaImageButton1_Click(object sender, EventArgs e)
        {
            PL.AjouterProduit ajouteprod = new PL.AjouterProduit();
            if (selectverify() == null)
            {
                for (int i = 0; i < dataGridViewproduit.Rows.Count; i++)
                {
                    if ((bool)dataGridViewproduit.Rows[i].Cells[0].Value == true)
                    {
                        ajouteprod.IDselect = (int)dataGridViewproduit.Rows[i].Cells[1].Value;
                        ajouteprod.nomproduit.Text = dataGridViewproduit.Rows[i].Cells[2].Value.ToString();
                        ajouteprod.dateproduit.Text = dataGridViewproduit.Rows[i].Cells[3].Value.ToString();
                        ajouteprod.qteproduit.Text = dataGridViewproduit.Rows[i].Cells[4].Value.ToString();
                        ajouteprod.prixproduit.Text = dataGridViewproduit.Rows[i].Cells[5].Value.ToString();
                    }
                }
                ajouteprod.labeltitrepro.Text = "Modifier fournisseur";
                ajouteprod.buttonactualiserpro.Visible = false;
                ajouteprod.ShowDialog();
            }
            else
            {
                MessageBox.Show(selectverify(), "Modification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            BL.ProduitCls clproduit = new BL.ProduitCls();
            //pour supprimer tout les fournisseurs ajouter
            int select = 0;
            for (int i = 0; i < dataGridViewproduit.Rows.Count; i++)
            {
                if ((bool)dataGridViewproduit.Rows[i].Cells[0].Value == true)
                {
                    select++;
                }
            }
            if (select == 0)
            {
                MessageBox.Show("aucun produit selectionner", "suppression", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            if (select > 1)
            {
                DialogResult R = MessageBox.Show("Voulez-vous vraiment supprimer", "suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (R == DialogResult.Yes)
                {
                    for (int i = 0; i < dataGridViewproduit.Rows.Count; i++)
                    {
                        if ((bool)dataGridViewproduit.Rows[i].Cells[0].Value == true)
                        {
                            clproduit.supprimer_fournisseur(int.Parse(dataGridViewproduit.Rows[i].Cells[1].Value.ToString()));
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
            var listerecherche = db.Produit.ToList();
            if (comborechercheproduit.Text != "")
            {
                switch (comborechercheproduit.Text)
                {
                    case "Nom Produit":
                        listerecherche = (List<Produit>)listerecherche.Where(s => s.Nom_produit.IndexOf(rechercheproduit.Text, StringComparison.CurrentCultureIgnoreCase) != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                    case "Quantité":
                        listerecherche = (List<Produit>)listerecherche.Where(s => s.Qte_produit != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                    case "Prix":
                        listerecherche = (List<Produit>)listerecherche.Where(s => s.Prix_produit != -1);
                        //StringComparaison.CurrentCultureIgnore = sois j'ecris la premiere lettre en majuscule sois en minuscule
                        // != -1 existedans db
                        break;

                }
            }
            dataGridViewproduit.Rows.Clear();
            //ajouter liste recherche dans data grid view
            foreach (var l in listerecherche)
            {
                dataGridViewproduit.Rows.Add(false, l.ID_produit, l.Nom_produit, l.Date_entrée_stock, l.Qte_produit, l.Prix_produit);
            }
        }
    }
}
