using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using TransferObject;
namespace PresentationLayer
{
    public partial class Home : Form
    {
        private Account account;
        public Home(Account acc)
        {
            InitializeComponent();
            this.account = acc;
        }

        private void Home_Load(object sender, EventArgs e)
        {
            

            lbWelcomeUser.Text = "Chao mung " + account.Name + " den voi quan ly thu vien";

        }

        private void viewPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPersonalProfile frmPersonalProfile = new FrmPersonalProfile(account);
            frmPersonalProfile.ShowDialog();

        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
