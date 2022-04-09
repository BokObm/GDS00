using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEST_DE_STOCK.BL
{
    internal class ProduitCls
    {
        private GEST_DE_STOCKEntities db = new GEST_DE_STOCKEntities();
        private Produit P;
        public bool Ajouter_produit(String Nom, DateTime Date, int Qte,int Prix)
        {
            P = new Produit();
            P.Nom_produit = Nom;
            P.Date_entrée_stock = Date;
            P.Qte_produit = Qte;
            P.Prix_produit = Prix;
            if (db.Produit.SingleOrDefault(s => s.Nom_produit == Nom) == null)
            {
                db.Produit.Add(P);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Modifier_produit(int ID, String Nom, DateTime Date, int Qte, int Prix)
        {
            P = new Produit();
            P = db.Produit.SingleOrDefault(s => s.ID_produit == ID); // verifier si id fournisseur existe 
            if (P != null) // existe
            {
                //nouveau
                P.Nom_produit = Nom;
                P.Date_entrée_stock = Date;
                P.Qte_produit = Qte;
                P.Prix_produit = Prix;
                db.SaveChanges(); // sauvegarder les nouveau element dans la base de donner 
            }
        }
        public void supprimer_produit(int ID)
        {
            P = new Produit();
            P = db.Produit.SingleOrDefault(s => s.ID_produit == ID);
            if (P != null)
            {
                db.Produit.Remove(P);
                db.SaveChanges();
            }

        }

        internal bool Ajouter_produit(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }

        internal void Modifier_produit(int dselect, string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }

        internal void supprimer_fournisseur(int v)
        {
            throw new NotImplementedException();
        }
    }
}
