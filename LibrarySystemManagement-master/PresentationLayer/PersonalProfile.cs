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
    public partial class FrmPersonalProfile : Form
    {
        private Account account;
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
            if (this.account!=null)
            {
                txtName.Text = account.Name;
                
                if (!account.NgaySinh.HasValue)
                    dtPersonal.Value = DateTime.Now;
                Console.WriteLine(account.Country);
                Console.WriteLine(account.Email);
                Console.WriteLine(account.Phone);
                txtCountry.Text = account.Country;
                txtEmail.Text = account.Email;
                txtPhone.Text = account.Phone;
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
    }
}
