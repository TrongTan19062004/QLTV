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
namespace PresentationLayer
{
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
            int count = 3;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form formRegister = new Register();
            formRegister.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * elect * from Users u join User_Role r on u.user_Role= r.userType_id
  where user_name='Tran Thi Truc Mai' and  user_password ='mai179@' and userType_name='Staff'
             */
            string cnStr = "Data Source=LAPTOP-H6KBR02F\\SQLEXPRESS01;Initial Catalog=LibraryManagementDatabase;Integrated Security=True;TrustServerCertificate=True";

            SqlConnection cn = new SqlConnection(cnStr);
            cn.Open();
            string itemText = comboBox1.SelectedItem.ToString();
            String sql = "SELECT COUNT(user_name) FROM Users u join User_Role r on u.user_Role = r.userType_id  where user_username = '" + textBox1.Text + "' and user_password = '" + textBox2.Text + "' and userType_name = '" + itemText + "'";
            SqlCommand cmd = new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            int result = (int)cmd.ExecuteScalar();
            if (result > 0)
            {
                //Home home = new Home();


                //home.ShowDialog();
                this.Hide();
                MessageBox.Show("Dang nhap thanh cong");

            }
            else
            {
                throw new Exception("Dang nhap that bai");
            }
            cn.Close();

        }
    }
}
