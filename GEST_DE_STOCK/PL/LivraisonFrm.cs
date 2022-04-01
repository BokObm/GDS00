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
    public partial class LivraisonFrm : UserControl
    {
        private static LivraisonFrm LivraisonUser;
        public static LivraisonFrm Instance
        {
            get
            {
                if (LivraisonUser == null)
                {
                    LivraisonUser = new LivraisonFrm();
                }
                return LivraisonUser;
            }
        }
        public LivraisonFrm()
        {
            InitializeComponent();
        }

        private void LivraisonFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
