using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Account
    {
        private int _id;
        private string _name;
        private DateTime? ngaySinh;

        private string _username;
        private string _password;
        private int role_id;
        private string phone;
        private DateTime user_createdAt;
        private string email;
        private string country;
        private string avatar;
        private UserType type;
        public Account(int id, string name, DateTime? ngaySinh, string username, string password, int role_id,DateTime user_createdAt,string email,string phone,string country,string avatar,UserType type)
        {
            this._id = id;
            this._name = name;
            this.ngaySinh= ngaySinh;
            this._username = username;
            this._password = password;
            this.role_id = role_id;
            this.phone = phone;
            this.email = email;
            this.user_createdAt = user_createdAt;
            this.country = country;
            this.avatar = avatar;
            this.type = type;
        }
        public Account()
        {

        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public DateTime? NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }

        public string Username
        {
            get { return _username; }
            set { _username = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int RoleId
        {
            get { return role_id; }
            set { role_id = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public DateTime UserCreatedAt
        {
            get { return user_createdAt; }
            set { user_createdAt = value; }
        }
        public string Email
        {
            get { return email; }   
            set { email = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }
        public UserType Type
        {
            get { return type; }
            set { type = value; }
        }



    }
}
