using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinessLayer;
using TransferObject;
using System.IO;
namespace PresentationLayer
{
    public partial class FrmPersonalProfile : Form
    {
        private Account account;
        private string filePath;
        public FrmPersonalProfile(Account acc)
        {
            InitializeComponent();
            this.account = acc;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PersonalProfile_Load(object sender, EventArgs e)
        {
            //    string cnStr = "Data Source=LAPTOP-H6KBR02F\\SQLEXPRESS01;Initial Catalog=LibraryManagementDatabase;Integrated Security=True;TrustServerCertificate=True";
            //    SqlConnection cn = new SqlConnection(cnStr);
            //    String sql = "select "+ txtEmail.Text+" , "+dtPersonal.Text+" , "+txtEmail.Text+" , "+ txtPhone.Text+","+txtCountry.Text+" from Users";

            //    SqlCommand cmd = new SqlCommand(sql, cn);
            //    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //    cmd.CommandType = CommandType.Text;
            //    DataTable dataTable = new DataTable();
            //    adapter.Fill(dataTable);
            AccountBL accountBL = new AccountBL();
            this.account=accountBL.GetAccountById(this.account.Id);
            if (this.account!=null)
            {
                txtName.Text = account.Name;

                dtPersonal.Value = account.NgaySinh ?? DateTime.Now;

                
                txtCountry.Text = account.Country;
                txtEmail.Text = account.Email;
                txtPhone.Text = account.Phone;
                if (!string.IsNullOrEmpty(account.Avatar) && File.Exists(account.Avatar))
                {
                    picPersonalImage.Image = Image.FromFile(account.Avatar);
                    filePath = account.Avatar;

                }
                else
                {
                    // Đường dẫn null hoặc file không tồn tại → dùng ảnh mặc định
                    picPersonalImage.Image = Properties.Resources.Screenshot_2025_04_06_093835;
                    // hoặc picAvatar1.Image = Image.FromFile("path/to/default.jpg");
                }

            }
            else
            {
                txtName.Text = "abc";
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AccountBL accountBL = new AccountBL();

                // Lấy thông tin từ các control
                string name = txtName.Text;
                DateTime date = dtPersonal.Value;
                string country = txtCountry.Text;
                string email = txtEmail.Text;
                string phone = txtPhone.Text;
                string username = account.Username;
                string password = account.Password;
                int role_id = account.RoleId;
                UserType role = account.Type;
                // Ảnh đại diện (nếu bạn có biến lưu file path)
                string avatarPath = string.IsNullOrEmpty(filePath) ? "" : filePath;

                DateTime user_createdAt =account.UserCreatedAt;
                // Giả sử bạn đã có ID của người dùng cần cập nhật
                int userId = account.Id;

                Account updatedAccount = new Account
                {
                    Id = userId,
                    Name = name,
                    NgaySinh = date,
                    Username = username,
                    Password = password,
                    RoleId = role_id,
                    Phone = phone,
                    Email = email,
                    UserCreatedAt = user_createdAt,
                    Country = country,
                    Avatar = avatarPath,
                    Type = role
                };

                bool result = accountBL.UpdateAccount(updatedAccount,role.ToString()); // bạn cần có hàm này

                if (result)
                {
                    
                    MessageBox.Show("Cập nhật thành công!");
                    account = updatedAccount;
                    txtEmail.Text = account.Email;
                    txtPhone.Text = account.Phone;
                    txtCountry.Text = account.Country;
                    txtName.Text = account.Name;
                    dtPersonal.Value = account.NgaySinh.Value;
                }

                else
                    MessageBox.Show("Cập nhật thất bại!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnOpenImagePersonalProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn ảnh đại diện";
            openFileDialog.Filter = "Ảnh (*.jpg; *.jpeg; *.png; *.bmp)|*.jpg;*.jpeg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = openFileDialog.FileName;

                // Ví dụ: hiện ảnh lên PictureBox
                picPersonalImage.Image = Image.FromFile(filePath);

                
            }
        }
    }
}
