using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
namespace DataLayer
{
    public class AccountDL:DataProvier
    {
        
        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>();
            
            string sql = @"select u.user_id,user_name,user_birth,user_country,user_username, user_password,user_email,user_createdAt,user_avatar,role.userType_name from Users u join User_Role role on u.user_Role=role.userType_id";
            DataTable result = MyExcuteReader(sql, CommandType.Text);
            foreach (DataRow dr in result.Rows)
            {
                Account account = new Account();
                account.Id = dr[0] != DBNull.Value ? Convert.ToInt32(dr[0]) : 0;
                account.Name = dr[1] != DBNull.Value ? dr[1].ToString() : null;
                account.NgaySinh = dr[2] != DBNull.Value ? Convert.ToDateTime(dr[2]) : (DateTime?)null;
                account.Country = dr[3] != DBNull.Value ? dr[3].ToString() : null;
                account.Username = dr[4] != DBNull.Value ? dr[4].ToString() : null;
                account.Password = dr[5] != DBNull.Value ? dr[5].ToString() : null;
                account.Email = dr[6] != DBNull.Value ? dr[6].ToString() : null;
                account.UserCreatedAt = Convert.ToDateTime(dr[7]);
                account.Avatar = dr[8] != DBNull.Value ? dr[8].ToString() : null;

                account.Type = new UserType();
                account.Type.UserTypeName = dr[9] != DBNull.Value ? dr[9].ToString() : null;
                accounts.Add(account);
            }
            return accounts;
        }
        public int addUser(Account account, string TypeName)
        {
            string sql = @"
    SET DATEFORMAT DMY;
    DECLARE @userType_id INT;
    SELECT @userType_id = userType_id FROM User_Role WHERE userType_name = @UserType;

    INSERT INTO Users (user_id,
        user_name, user_birth, user_Role, user_country, user_username,
        user_password, user_email, user_createdAt, user_phone, user_avatar
    )
    VALUES (@user_id,
        @user_name, @user_birth, @userType_id, @user_country, @user_username,
        @user_password, @user_email, GETDATE(), @user_phone, @user_avatar
    );
";
            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@user_id",SqlDbType.Int){Value=account.Id},
    new SqlParameter("@user_name", SqlDbType.VarChar, 50) { Value =account.Name},
    new SqlParameter("@user_birth", SqlDbType.Date) { Value = account.NgaySinh },
    new SqlParameter("@user_country", SqlDbType.VarChar, 50) { Value = account.Country },
    new SqlParameter("@user_username", SqlDbType.VarChar, 50) { Value = account.Username },
    new SqlParameter("@user_password", SqlDbType.VarChar, 50) { Value = account.Password },
    new SqlParameter("@user_email", SqlDbType.VarChar, 50) { Value = account.Email },
    new SqlParameter("@user_phone", SqlDbType.VarChar, 20) { Value = account.Phone},
    new SqlParameter("@UserType",SqlDbType.VarChar,50){Value=TypeName},
    new SqlParameter("@user_avatar", SqlDbType.NVarChar, -1) { Value = account.Avatar } // hoặc byte[] nếu ảnh
            };
            return MyExcuteNonQuery(sql,CommandType.Text,parameters);

        }
        public int UpdateUser(Account account, string typeName)
        {
            string sql = @"
        SET DATEFORMAT DMY;
        DECLARE @userType_id INT;
        SELECT @userType_id = userType_id FROM User_Role WHERE userType_name = @UserType;

        UPDATE Users SET
            user_name = @user_name,
            user_birth = @user_birth,
            user_Role = @userType_id,
            user_country = @user_country,
            user_username = @user_username,
            user_password = @user_password,
            user_email = @user_email,
            user_phone = @user_phone,
            user_avatar = @user_avatar
        WHERE user_id = @user_id;
    ";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@user_id", SqlDbType.Int) { Value = account.Id },
        new SqlParameter("@user_name", SqlDbType.VarChar, 50) { Value = account.Name },
        new SqlParameter("@user_birth", SqlDbType.Date) { Value = account.NgaySinh },
        new SqlParameter("@user_country", SqlDbType.VarChar, 50) { Value = account.Country },
        new SqlParameter("@user_username", SqlDbType.VarChar, 50) { Value = account.Username },
        new SqlParameter("@user_password", SqlDbType.VarChar, 50) { Value = account.Password },
        new SqlParameter("@user_email", SqlDbType.VarChar, 50) { Value = account.Email },
        new SqlParameter("@user_phone", SqlDbType.VarChar, 20) { Value = account.Phone },
        new SqlParameter("@user_avatar", SqlDbType.NVarChar, -1) { Value = account.Avatar },
        new SqlParameter("@UserType", SqlDbType.VarChar, 50) { Value = typeName }
            };

            return MyExcuteNonQuery(sql, CommandType.Text, parameters);
        }
        public int DeleteUser(int userId)
        {
            string sql = "DELETE FROM Users WHERE user_id = @user_id";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@user_id", SqlDbType.Int) { Value = userId }
            };

            return MyExcuteNonQuery(sql, CommandType.Text, parameters);
        }
        public Account FindUserById(int userId)
        {
            string sql = @"
        SELECT u.user_id, user_name, user_birth, user_country, user_username,
               user_password, user_email, user_createdAt, user_avatar, role.userType_name,
               user_phone
        FROM Users u
        JOIN User_Role role ON u.user_Role = role.userType_id
        WHERE user_id = @user_id";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@user_id", SqlDbType.Int) { Value = userId }
            };

            DataTable result = MyExcuteReader(sql, CommandType.Text, parameters);

            if (result.Rows.Count == 0)
                return null;

            DataRow dr = result.Rows[0];
            Account account = new Account
            {
                Id = Convert.ToInt32(dr["user_id"]),
                Name = dr["user_name"].ToString(),
                NgaySinh = dr["user_birth"] != DBNull.Value ? Convert.ToDateTime(dr["user_birth"]) : (DateTime?)null,
                Country = dr["user_country"].ToString(),
                Username = dr["user_username"].ToString(),
                Password = dr["user_password"].ToString(),
                Email = dr["user_email"].ToString(),
                UserCreatedAt = Convert.ToDateTime(dr["user_createdAt"]),
                Avatar = dr["user_avatar"].ToString(),
                Phone = dr["user_phone"].ToString(),
                Type = new UserType { UserTypeName = dr["userType_name"].ToString() }
            };

            return account;
        }

    }

}

