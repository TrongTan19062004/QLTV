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
    public partial class HomeStaff : Form
    {
        private Account acc;
        public HomeStaff(Account acc)
        {
            InitializeComponent();
            this.acc = acc;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void documentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocumentManagement documentManagement = new DocumentManagement();
            documentManagement.ShowDialog();
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HomeStaff_Load(object sender, EventArgs e)
        {
            lbWelcome.Text = "Chao mung " + acc.Name + "den voi quan ly thu vien";
        }

        private void staffProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonalProfile frmPersonalProfile = new FrmPersonalProfile(acc);
            frmPersonalProfile.ShowDialog();
        }
    }
}
