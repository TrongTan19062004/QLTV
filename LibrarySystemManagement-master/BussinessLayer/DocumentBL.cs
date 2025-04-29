using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using TransferObject;
namespace BussinessLayer
{
    public class DocumentBL
    {
        private DocumentDL DocumentDL=new DocumentDL();
        public List<Document> GetDocuments()
        {
            return DocumentDL.GetDocuments();
        }
    }
}
