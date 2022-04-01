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
    public partial class CommandeFrm : UserControl
    {
        private static CommandeFrm CommandeUser;
        public static CommandeFrm Instance
        {
            get
            {
                if (CommandeUser == null)
                {
                    CommandeUser = new CommandeFrm();
                }
                return CommandeUser;
            }
        }
        public CommandeFrm()
        {
            InitializeComponent();
        }

        private void gunaShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CommandeFrm_Load(object sender, EventArgs e)
        {

        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }
    }
}
