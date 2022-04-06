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
        public bool Ajouter_Fournisseur(int ID,String Nom,String Email,String Adresse)
        {
            F = new Fournisseur();
            F.ID_fournisseur = ID;
            F.Nom_fournisseur= Nom;
            F.Mail_fournisseur= Email;
            F.Adresse_fournisseur= Adresse;
            if (db.Fournisseur.SingleOrDefault(s => s.Nom_fournisseur == Nom ) == null)
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

        internal bool Ajouter_Fournisseur(string text1, string text2, string text3, string text4)
        {
            throw new NotImplementedException();
        }
    }
}
