using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
        public bool addDocument(Document document,string authorName,string genreName,string documentType)
        {
            
            return DocumentDL.addDocument(document,authorName,genreName,documentType);
        }
        public bool updateDocument(Document document, string authorName, string genreName, string documentType)
        {
            return DocumentDL.UpdateDocument(document, authorName,genreName,documentType);
        }
        public Document searchDocument(int id)
        {
            return DocumentDL.searchDocument(id);
        }
        public bool deleteDocument(int id)
        {
            return DocumentDL.deleteDocument(id) > 0;
        }
    }
}
