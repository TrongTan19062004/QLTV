using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;
using DataLayer;
namespace BussinessLayer
{
    public class AccountBL
    {
        public AccountBL() { }
        private AccountDL accountDL=new AccountDL();
        public List<Account> getAccounts(){
            return accountDL.GetAccounts();
        }
        public bool  addAccount(Account account,String role)
        {
            return accountDL.addUser(account,role) > 0;
        }
        public bool UpdateAccount(Account account, string role)
        {
            return accountDL.UpdateUser(account, role) > 0;
        }
        public bool DeleteAccount(int userId)
        {
            return accountDL.DeleteUser(userId) > 0;
        }
        public Account GetAccountById(int userId)
        {
            return accountDL.FindUserById(userId);
        }

    }
}
