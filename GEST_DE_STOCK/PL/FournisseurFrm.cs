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
        }

        private void FournisseurFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
