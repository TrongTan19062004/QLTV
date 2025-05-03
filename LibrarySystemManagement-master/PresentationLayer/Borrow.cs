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
using BusinessLayer;

namespace PresentationLayer
{
        public partial class BorrowForm : Form
        {
                BorrowBL borrowBL = new BorrowBL();

            public BorrowForm()
            {
                InitializeComponent();
                borrow_dp.Value = DateTime.Today;
                return_dp.Value = DateTime.Today.AddDays(20);
            }

            private void btnSearchReader_Click(object sender, EventArgs e)
            {
                if (int.TryParse(txt_readerID.Text, out int readerId))
                {
                    var reader = borrowBL.GetReaderById(readerId);
                    if (reader != null)
                    {
                        txt_Name.Text = reader.FullName;
                        txt_Sđt.Text = reader.Phone;
                        txt_Email.Text = reader.Email;
                    }
                    else
                    {
                        MessageBox.Show("Reader not found");
                    }
                }
            }

            private void btnSearchDocument_Click(object sender, EventArgs e)
            {
                if (int.TryParse(txt_DocumentID.Text, out int documentId))
                {
                    var doc = borrowBL.GetDocumentById(documentId);
                    if (doc != null)
                    {
                        txt_DocumenetName.Text = doc.Title;
                    }
                    else
                    {
                        MessageBox.Show("Document not found");
                    }
                }
            }

            private void btnConfirm_Click(object sender, EventArgs e)
            {
                if (int.TryParse(txt_readerID.Text, out int readerId) &&
                    int.TryParse(txt_DocumentID.Text, out int documentId))
                {
                    Borrow borrow = new Borrow
                    {
                        ReaderId = readerId,
                        DocumentId = documentId,
                        BorrowDate = borrow_dp.Value,
                        ReturnDate = return_dp.Value
                    };

                    if (borrowBL.BorrowDocument(borrow))
                    {
                        MessageBox.Show("Borrow information saved successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Failed to save borrow information.");
                    }
                }
            }
        }
    }

