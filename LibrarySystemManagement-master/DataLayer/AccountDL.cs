using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
namespace DataLayer
{
    public class AccountDL:DataProvier
    {
        public AccountDL() { }
        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            
            string sql = @"select u.user_id,user_name,user_birth,user_country,user_username, user_password,user_email,user_createdAt,user_avatar,role.userType_name from Users u join User_Role role on u.user_Role=role.userType_id";
            DataTable result = MyExcuteReader(sql, CommandType.Text);
            foreach (DataRow dr in result.Rows)
            {
                Account account = new Account();

                account.Id = (int)dr[0];
                account.Name = dr[1]?.ToString() ;

                account.NgaySinh=Convert.ToDateTime(dr[2]);
                account.Country = dr[3]?.ToString() ;
                account.Username = dr[4]?.ToString() ;
                account.Password = dr[5]?.ToString() ;
                account.Email = dr[6]?.ToString() ;
                account.UserCreatedAt = Convert.ToDateTime(dr[7]);
                account.Avatar = dr[8]?.ToString() ;
                account.Type.UserTypeName = dr[9]?.ToString() ;
                accounts.Add(account);
            }
            return accounts;
        }
        //public bool addUser(Account account,string TypeName)
        //{

        //}
    }

    }

