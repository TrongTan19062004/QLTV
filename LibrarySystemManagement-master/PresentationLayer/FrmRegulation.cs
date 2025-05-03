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
    public partial class FrmRegulation : Form
    {
        RegulationBL regulationBL = new RegulationBL();
        public FrmRegulation()
        {
            InitializeComponent();
            dgvRegulation.DataSource= regulationBL.GetRegulations();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Kiểm tra ID bắt buộc phải có
            if (string.IsNullOrWhiteSpace(txtIdRegulation.Text))
            {
                MessageBox.Show("Vui lòng nhập Id để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int re_Id;
            if (!int.TryParse(txtIdRegulation.Text.Trim(), out re_Id))
            {
                MessageBox.Show("Vui lòng sửa định dạng Id (phải là số).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool hasUpdate = false;

                if (!string.IsNullOrWhiteSpace(txtDescriptionRegulation.Text))
                {
                    regulationBL.UpdateDescription(re_Id, txtDescriptionRegulation.Text.Trim());
                    hasUpdate = true;
                }

                if (!string.IsNullOrWhiteSpace(txtMaxBooksDayRegulation.Text))
                {
                    if (int.TryParse(txtMaxBooksDayRegulation.Text.Trim(), out int maxBooksDay))
                    {
                        regulationBL.UpdateMaxBookDays(re_Id, maxBooksDay);
                        hasUpdate = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng sửa định dạng MaxBooksDay (phải là số).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtFinePerDayRegulation.Text))
                {
                    if (int.TryParse(txtFinePerDayRegulation.Text.Trim(), out int finePerDay))
                    {
                        regulationBL.UpdateFinePerDays(re_Id, finePerDay);
                        hasUpdate = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng sửa định dạng FinePerDay (phải là số).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (!string.IsNullOrWhiteSpace(txtMaxBooksAllowed.Text))
                {
                    if (int.TryParse(txtMaxBooksAllowed.Text.Trim(), out int maxBooksAllowed))
                    {
                        regulationBL.UpdateMaxBookAllow(re_Id, maxBooksAllowed);
                        hasUpdate = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng sửa định dạng MaxBooksAllowed (phải là số).", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                if (hasUpdate)
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có trường nào được nhập để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                dgvRegulation.DataSource = regulationBL.GetRegulations();
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}