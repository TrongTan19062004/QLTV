using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BussinessLayer;
using TransferObject;
namespace PresentationLayer
{
    public partial class UserManagementForStaff : Form
    {
        private string filePath;
        public UserManagementForStaff()
        {
            InitializeComponent();
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UserManagementForStaff_Load(object sender, EventArgs e)
        {
            AccountBL accountBL=new AccountBL();
            dgvUserManagement1.DataSource = accountBL.getAccounts();
        }

        private void btnOpenImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh đại diện";
            openFileDialog.Filter = "Ảnh (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                 filePath = openFileDialog.FileName;

                // Ví dụ: hiện ảnh lên PictureBox
                picAvatar1.Image = Image.FromFile(filePath);

                // Hoặc: chuyển sang mảng byte để lưu vào SQL (nếu cần)
                byte[] imageBytes = File.ReadAllBytes(filePath);
            }
        }
        
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            //try
            {
                AccountBL accountBL = new AccountBL();
                int id = int.Parse(txtId1.Text);
                string name = txtName1.Text;
                DateTime date = dtPicBirth1.Value;
                string country = txtCountry1.Text;
                string username = txtUserName1.Text;
                string password=txtPass1.Text;
                string phone = txtPhone1.Text;
                string email = txtEmail1.Text;
                string TypeName = cbtype1.SelectedItem.ToString();
                UserType userType = new UserType();
                userType.UserTypeName = TypeName;
                
                Account account = new Account(id,name,date,username,password, userType.UserTypeId,DateTime.Now,email,phone,country,filePath,userType);
                bool check = accountBL.addAccount(account, TypeName);
                if (check) {
                    dgvUserManagement1.DataSource = accountBL.getAccounts();
                }
                else
                {
                    MessageBox.Show("Them that bai");
                }
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("Xem lại thông tin");
            //}
        }

        private void btnSearchUser2_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(txtId1.Text);
                AccountBL accountBL = new AccountBL();
                Account account = accountBL.GetAccountById(userId);

                if (account != null)
                {
                    txtName1.Text = account.Name;
                    dtPicBirth1.Value = account.NgaySinh ?? DateTime.Now;
                    txtCountry1.Text = account.Country;
                    txtUserName1.Text = account.Username;
                    txtPass1.Text = account.Password;
                    txtPhone1.Text = account.Phone;
                    txtEmail1.Text = account.Email;
                    cbtype1.Text = account.Type?.UserTypeName;

                    if (!string.IsNullOrEmpty(account.Avatar) && File.Exists(account.Avatar))
                    {
                        picAvatar1.Image = Image.FromFile(account.Avatar);
                    }
                    dgvUserManagement1.DataSource = new List<Account> { account };
                }
                else
                {
                    MessageBox.Show("Không tìm thấy người dùng.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }


        private void btnUpdateUser2_Click(object sender, EventArgs e)
        {
            try
            {
                AccountBL accountBL = new AccountBL();
                int id = int.Parse(txtId1.Text);
                string name = txtName1.Text;
                DateTime date = dtPicBirth1.Value;
                string country = txtCountry1.Text;
                string username = txtUserName1.Text;
                string password = txtPass1.Text;
                string phone = txtPhone1.Text;
                string email = txtEmail1.Text;
                string typeName = cbtype1.SelectedItem?.ToString();

                UserType userType = new UserType { UserTypeName = typeName };
                Account account = new Account(id, name, date, username, password, 0, DateTime.Now, email, phone, country, filePath, userType);

                bool updated = accountBL.UpdateAccount(account, typeName);

                if (updated)
                {
                    dgvUserManagement1.DataSource = accountBL.getAccounts();
                    MessageBox.Show("Cập nhật thành công.");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi cập nhật: " + ex.Message);
            }
        }


        private void btnDeleteUser2_Click(object sender, EventArgs e)
        {
            try
            {
                int userId = int.Parse(txtId1.Text);
                AccountBL accountBL = new AccountBL();

                DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa người dùng này?", "Xác nhận", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    bool deleted = accountBL.DeleteAccount(userId);
                    if (deleted)
                    {
                        dgvUserManagement1.DataSource = accountBL.getAccounts();
                        MessageBox.Show("Xóa thành công.");
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xóa: " + ex.Message);
            }
        }

    }
}
