using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//<<<<<<< HEAD
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
//=======
//using System.Drawing;
//using System.Linq;
//using System.Text;
//>>>>>>> Tan
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Register : Form
    {
//<<<<<<< HEAD
        String cnn = "Data Source=LAPTOP-IRQBKCBQ;Initial Catalog=LibraryManagementDatabase;Integrated Security=True;MultipleActiveResultSets=True;TrustServerCertificate=True";
//=======
//>>>>>>> Tan
        public Register()
        {
            InitializeComponent();
        }

//<<<<<<< HEAD
        private void signUp_btn_Click(object sender, EventArgs e)
        {
                string userId = GenerateUserId();
                string fullName = reg_name.Text.Trim();
                string email = reg_email.Text.Trim();
                string phone = reg_phone.Text.Trim();
                DateTime birthdate = reg_birthdate.Value;
                string username = reg_username.Text.Trim();
                string password = reg_pass.Text;
                string confirmPassword = reg_confirm.Text;

                // Kiểm tra hợp lệ
                if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(email) ||
                    string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                    return;
                }

                if (password != confirmPassword)
                {
                    MessageBox.Show("Mật khẩu xác nhận không khớp.");
                    return;
                }
                if (!Regex.IsMatch(phone, @"^0\d{9}$"))
                {
                    MessageBox.Show("Số điện thoại không hợp lệ. Vui lòng nhập 10 chữ số bắt đầu bằng 0.");
                    return;
                }
                if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
                {
                    MessageBox.Show("Email không đúng định dạng.");
                    return;
                }


            // Thêm vào CSDL
            using (SqlConnection conn = new SqlConnection(cnn))
                {
                    
                    try
                    {   conn.Open();
                        string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE user_username = @Username";
                        SqlCommand checkCmd = new SqlCommand(checkUserQuery, conn);
                        checkCmd.Parameters.AddWithValue("@Username", username);
                        int count = (int)checkCmd.ExecuteScalar();
                        if (count > 0)
                        {
                            MessageBox.Show("Tên đăng nhập đã tồn tại. Vui lòng chọn tên khác.");
                            return;
                        }
                        string query = "INSERT INTO Users (user_id, user_name, user_email, user_phone, user_birth, user_username, user_password) " +
                                   "VALUES (@UserId, @FullName, @Email, @Phone, @Birthdate, @Username, @Password)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Phone", phone);
                        cmd.Parameters.AddWithValue("@Birthdate", birthdate);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        cmd.ExecuteNonQuery();
                            DialogResult result = MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập ngay không?",
                                   "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            if (result == DialogResult.Yes)
                            {
                                this.Hide(); // Ẩn form đăng ký hiện tại
                                SignIn loginForm = new SignIn(); // mở form đăng nhập
                                loginForm.Show();
                            }
                            else
                            {
                                // Giữ nguyên form đăng ký hoặc reset lại các field nếu muốn
                                ClearFormFields();
                            }
                }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message);
                    }
                }
            
        }
        private string GenerateUserId()
        {
            Random rand = new Random();
            return rand.Next(100000, 999999).ToString();
        }
        private void ClearFormFields()
        {
            reg_name.Clear();
            reg_email.Clear();
            reg_phone.Clear();
            reg_username.Clear();
            reg_pass.Clear();
            reg_confirm.Clear();
            reg_birthdate.Value = DateTime.Now;
//=======
//        private void Register_Load(object sender, EventArgs e)
//        {

//>>>>>>> Tan
        }
    }
}
