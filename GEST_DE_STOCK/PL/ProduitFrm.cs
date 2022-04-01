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
        }

        private void ProduitFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
