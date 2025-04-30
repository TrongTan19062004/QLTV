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
using TransferObject;
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
            try
            {
                DocumentBL documentBL = new DocumentBL();
                int id = int.Parse(txtDocument_Id.Text);
                DateTime dateTime = dtPublicationYear.Value;
                string title = txtTitle.Text;
                string langiage = txtLanguage.Text;
                int quantity = int.Parse(txtQuantity.Text);
                int price = int.Parse(txtPrice.Text);
                string authorName = txtAuthor_name.Text;
                int document_page = int.Parse(txtPage.Text);
                string Genre_name = txtGenre_name.Text;
                string Type_name = txtType_Name.Text;
                Document d = new Document();
                d.DocumentId = id;
                d.Title = title;
                d.Language = langiage;
                d.PublicationYear = dateTime;
                d.Quantity = quantity;
                d.DocumentPage = document_page;
                d.DocumentPage = document_page;
                bool check = documentBL.addDocument(d, authorName, Genre_name, Type_name);
                dgvDocuments.DataSource = documentBL.GetDocuments();
                MessageBox.Show("Thêm thành công");
            }
            catch (FormatException)
            {
                // Nếu nhập không phải là một số hợp lệ
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }

        private void btnUpdateDocument_Click(object sender, EventArgs e)
        {
            try
            {
                DocumentBL documentBL = new DocumentBL();
                int id = int.Parse(txtDocument_Id.Text);
                DateTime dateTime = dtPublicationYear.Value;
                string title = txtTitle.Text;
                string langiage = txtLanguage.Text;
                int quantity = int.Parse(txtQuantity.Text);
                int price = int.Parse(txtPrice.Text);
                string authorName = txtAuthor_name.Text;
                int document_page = int.Parse(txtPage.Text);
                string Genre_name = txtGenre_name.Text;
                string Type_name = txtType_Name.Text;
                Document d = new Document();
                d.DocumentId = id;
                d.Title = title;
                d.Language = langiage;
                d.Quantity = quantity;
                d.DocumentPage = document_page;
                d.PublicationYear = dateTime;
                bool check = documentBL.updateDocument(d, authorName, Genre_name, Type_name);
                dgvDocuments.DataSource = documentBL.GetDocuments();
                MessageBox.Show("Sửa thành công");
            }
            catch (FormatException)
            {
                // Nếu nhập không phải là một số hợp lệ
                MessageBox.Show("Dữ liệu nhập không hợp lệ");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnSearchDocument_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtDocument_Id.Text);
                DocumentBL documentBL = new DocumentBL();
                Document d = documentBL.searchDocument(id);
                dgvDocuments.DataSource = new List<Document> { d };
                MessageBox.Show("Tìm thấy");
            }
            catch (FormatException)
            {
                // Nếu nhập không phải là một số hợp lệ
                MessageBox.Show("Vui lòng nhập một ID hợp lệ.");
            }
            catch (Exception ex) { 
                throw ex;
            }
            

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

        private void btnDeleteDocument_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtDocument_Id.Text);
                DocumentBL documentBL = new DocumentBL();
                
                bool check = documentBL.deleteDocument(id);
                dgvDocuments.DataSource = documentBL.GetDocuments();
                MessageBox.Show("Xóa thành công");
            }
            catch (FormatException)
            {
                // Nếu nhập không phải là một số hợp lệ
                MessageBox.Show("Vui lòng nhập một ID hợp lệ.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
