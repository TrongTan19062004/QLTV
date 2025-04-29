using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public  class DataProvier
    {
        private SqlConnection cn;
        public DataProvier() {
            string cnStr = "Data Source=LAPTOP-H6KBR02F\\SQLEXPRESS01;Initial Catalog=LibraryManagementDatabase;Integrated Security=True;";
            cn=new SqlConnection(cnStr);
            
        }
        public void connect()
        {
            if (cn != null && cn.State == ConnectionState.Closed)
            {

                cn.Open();
            }
        }
        public void Disconnect()
            {
                if(cn!=null && cn.State == ConnectionState.Open)
            {
                cn.Close();
            }
            }
        public object MyExcuteScalar(String sql, CommandType type)
        {
            SqlCommand cmd= new SqlCommand(sql, cn);
            cmd.CommandType = CommandType.Text;
            try
            {
                return cmd.ExecuteScalar();
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public object MyExcuteNonQuery(String sql, CommandType type)
        {
            SqlCommand Command = new SqlCommand(sql, cn);
            Command.CommandType = CommandType.Text;
            try
            {
                connect();
                return Command.ExecuteNonQuery();
            }
            catch(SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally {
                Disconnect();
            }
        }
        public DataTable MyExcuteReader(String sql, CommandType type)
        {
            SqlCommand Command = new SqlCommand(sql, cn);
            Command.CommandType = CommandType.Text;
            try
            {
                connect();
                DataTable dt = new DataTable();
                dt.Load(Command.ExecuteReader());

                return dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }
    }
}
