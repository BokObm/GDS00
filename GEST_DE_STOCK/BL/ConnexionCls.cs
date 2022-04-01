using System.Linq;

namespace GEST_DE_STOCK.BL
{
    internal class ConnexionCls
    {
        public bool ConnexionValide(GEST_DE_STOCKEntities dB , string ID, string MDP)
        {
            Employe E = new Employe();
            E.ID_employe = ID;
            E.Mdp_user= MDP;
            if(dB.Employe.SingleOrDefault(s=>s.ID_employe==ID && s.Mdp_user == MDP)!=null)
            {
                return true;
            }
            else
            {
                return false;
            }
              
        }
    }
}
