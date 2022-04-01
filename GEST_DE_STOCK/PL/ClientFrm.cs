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
    public partial class ClientFrm : UserControl
    {
        private static ClientFrm ClientUser;
        public static ClientFrm Instance
        {
            get
            {
                if (ClientUser == null)
                {
                    ClientUser = new ClientFrm();
                }
                return ClientUser;
            }
        }
        public ClientFrm()
        {
            InitializeComponent();
        }

        private void ClientFrm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
