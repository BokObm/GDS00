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
    public partial class VenteFrm : UserControl
    {
        private static VenteFrm VenteInstance;
        public static VenteFrm Instance
        {
            get
            {
                if (VenteInstance == null)
                {
                    VenteInstance = new VenteFrm();
                }
                return VenteInstance;
            }
        }
        public VenteFrm()
        {
            InitializeComponent();
        }

        private void VenteFrm_Load(object sender, EventArgs e)
        {

        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            PL.AjouterVente ajouteven = new AjouterVente();
            ajouteven.ShowDialog();
        }
    }
}
