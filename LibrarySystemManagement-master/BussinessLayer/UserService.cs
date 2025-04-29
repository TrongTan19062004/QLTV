using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;

namespace BussinessLayer
{
    public class UserService
    {
        public static UserService _instance;
        Account acc;
        public static UserService Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new UserService();

                }
                return _instance;
            }
        }
        public Account account
        {
            
            
                 get { return acc; }
            
        }


    }
}
