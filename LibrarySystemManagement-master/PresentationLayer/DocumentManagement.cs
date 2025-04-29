using BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class DocumentManagement : Form
    {
        private DocumentBL documentBL=new DocumentBL(); 
        public DocumentManagement()
        {
            InitializeComponent();
        }

        private void btnAddDocument_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateDocument_Click(object sender, EventArgs e)
        {

        }

        private void btnSearchDocument_Click(object sender, EventArgs e)
        {

        }

        private void DocumentManagement_Load(object sender, EventArgs e)
        {
            dgvDocuments.DataSource=documentBL.GetDocuments();
        }

        private void txtType_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGenre_name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
