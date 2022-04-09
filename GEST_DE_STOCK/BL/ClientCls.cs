using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEST_DE_STOCK.BL
{
    internal class ClientCls
    {
        private GEST_DE_STOCKEntities db = new GEST_DE_STOCKEntities();
        private Client C; // table client
        public bool Ajouter_Client(String Nom,String Prenom,int Telephone,String Email,String Adresse,String Ville)
        {
            C = new Client();
            C.Nom_client = Nom;
            C.Prenom_client = Prenom;
            C.Email_client = Email;
            C.Adresse_client = Adresse;
            C.Ville_client = Ville;

            if(db.Client.SingleOrDefault(s => s.Nom_client == Nom && C.Prenom_client == Prenom ) == null)
            {
                db.Client.Add(C);
                db.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
            
        }

        internal bool Ajouter_Client( string text2, string text3, string text4, string text5, string text6, string text7)
        {
            throw new NotImplementedException();
        }
        public void Modifier_client(int ID,String Nom, String Prenom, int Telephone, String Email, String Adresse, String Ville)
        {
            C = new Client();
            C = db.Client.SingleOrDefault(s => s.ID_client == ID); // verifier si id client existe 
            if(C != null) // existe
            {
                //nouveau
                C.Nom_client = Nom; 
                C.Prenom_client = Prenom;
                C.Email_client = Email;
                C.Adresse_client = Adresse;
                C.Ville_client = Ville;
                db.SaveChanges(); // sauvegarder les nouveau element dans la base de donner 
            }
        }

        internal void Modifier_client(int dselect, string text1, string text2, string text3, string text4, string text5, string text6)
        {
            throw new NotImplementedException();
        }
        public void supprimer_client(int ID)
        {
            C = new Client();
            C = db.Client.SingleOrDefault(s => s.ID_client == ID);
            if(C != null)
            {
                db.Client.Remove(C);
                db.SaveChanges();
            }

        }
    }
}
