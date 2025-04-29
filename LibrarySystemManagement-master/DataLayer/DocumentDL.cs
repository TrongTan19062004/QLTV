using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class DocumentDL
    {
        private DataProvier data = new DataProvier();

        public List<Document> GetDocuments()
        {
            List<Document> listDocument = new List<Document>();
            // TODO: Thêm code lấy dữ liệu từ database nếu cần
            string sql = "SELECT document_id,Publication_Year,Title,Language,quantity,price,a.Author_name,d.document_page,g.Genre_name,d.document_image,dtype.TypeName FROM Document d  JOIN Author a on d.author_id=a.Author_id JOIN Genre g on g.Genre_id=d.genre_id  JOIN DocumentType dtype on dtype.TypeId=d.DocumentType_id";
            
            DataTable result = data.MyExcuteReader(sql, CommandType.Text);
            foreach (DataRow dr in result.Rows)
            {
                Document d = new Document();
                d.DocumentId = dr["document_id"] != DBNull.Value ? Convert.ToInt32(dr["document_id"]) : 0;
                d.PublicationYear = Convert.ToDateTime(dr["Publication_Year"]);
                d.Title = dr["Title"]?.ToString();
                d.Language = dr["Language"]?.ToString();
                d.Quantity = dr["quantity"] != DBNull.Value ? Convert.ToInt32(dr["quantity"]) : 0;
                d.Money = dr["price"] != DBNull.Value ? Convert.ToInt32(dr["price"]) : 0;
                d.AuthorName = dr["Author_name"]?.ToString();
                d.DocumentPage = dr["document_page"] != DBNull.Value ? Convert.ToInt32(dr["document_page"]) : 0;
                d.GenreName = dr["Genre_name"]?.ToString();
                d.DocumentImage = dr["document_image"] != DBNull.Value ? dr["document_image"].ToString() : null;
                d.TypeName = dr["TypeName"]?.ToString();
                listDocument.Add(d);
            }
            return listDocument;
        }
    }
}
        
             
        
    
       
    

