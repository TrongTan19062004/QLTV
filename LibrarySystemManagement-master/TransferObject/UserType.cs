using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class UserType
    {
        private int userTypeId;
        private string userTypeName;
        private string description;

        public int UserTypeId
        {
            get { return userTypeId; }
            set { userTypeId = value; }
        }

        public string UserTypeName
        {
            get { return userTypeName; }
            set { userTypeName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }

}
