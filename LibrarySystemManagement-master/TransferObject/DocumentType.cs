using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class DocumentType
    {
        private int typeId;
        private string typeName;
        private string description;

        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }

}
