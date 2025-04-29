using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace PresentationLayer
{
    public partial class Admin : Form
    {
        private Account acc;
        public Admin(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void adminInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonalProfile frmPersonalProfile = new FrmPersonalProfile(acc);
            frmPersonalProfile.ShowDialog();
        }
    }
}
