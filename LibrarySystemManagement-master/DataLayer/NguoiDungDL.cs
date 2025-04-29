using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
namespace DataLayer
{
    public  class NguoiDungDL
    {
        public string connectString = "Data Source=LAPTOP-H6KBR02F\\SQLEXPRESS01;Initial Catalog=LibraryManagementDatabase;Integrated Security=True;Trust Server Certificate=True";
        public Account getAccountByUserNameAndPassword(string username,string password)
        {
            SqlConnection cn = new SqlConnection(connectString);
            cn.Open();
            string query = "select * from Users where user_username='" + username + "' and user_password ='" + password + "'";
            SqlCommand cmd= new SqlCommand(query, cn);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Account userNguoiDung = new Account();
                userNguoiDung.Username = username;
                userNguoiDung.Password = password;
                userNguoiDung.Id = int.Parse(sqlDataReader["user_id"].ToString());

                userNguoiDung.Name = sqlDataReader["user_name"].ToString();

                userNguoiDung.Email= sqlDataReader["user_email"].ToString();
                userNguoiDung.UserCreatedAt = DateTime.Parse(sqlDataReader["user_createdAt"].ToString());
                
            }

            cn.Close();
            return null;
        }
        
        
    }
}
