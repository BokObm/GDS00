using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEST_DE_STOCK.BL
{
    internal class FornissuerCls
    {
        private GEST_DE_STOCKEntities db = new GEST_DE_STOCKEntities();
        private Fournisseur F;
        public bool Ajouter_Fournisseur(String Nom, String Email, String Adresse)
        {
            F = new Fournisseur();
            F.Nom_fournisseur = Nom;
            F.Mail_fournisseur = Email;
            F.Adresse_fournisseur = Adresse;
            if (db.Fournisseur.SingleOrDefault(s => s.Nom_fournisseur == Nom) == null)
            {
                db.Fournisseur.Add(F);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Modifier_fournisseur(int ID, String Nom, String Adresse, String Email)
        {
            F = new Fournisseur();
            F = db.Fournisseur.SingleOrDefault(s => s.ID_fournisseur == ID); // verifier si id fournisseur existe 
            if (F != null) // existe
            {
                //nouveau
                F.Nom_fournisseur = Nom;
                F.Adresse_fournisseur = Adresse;
                F.Mail_fournisseur = Email; 
                db.SaveChanges(); // sauvegarder les nouveau element dans la base de donner 
            }
        }
        public void supprimer_fournisseur(int ID)
        {
            F = new Fournisseur();
            F = db.Fournisseur.SingleOrDefault(s => s.ID_fournisseur == ID);
            if (F != null)
            {
                db.Fournisseur.Remove(F);
                db.SaveChanges();
            }

        }
    }
}
