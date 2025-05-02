using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class DocumentDL : DataProvier
    {
        private DataProvier data = new DataProvier();

        public List<Document> GetDocuments()
        {
            List<Document> listDocument = new List<Document>();
            // TODO: Thêm code lấy dữ liệu từ database nếu cần
            string sql = "SELECT document_id,Publication_Year,Title,Language,quantity,price,a.Author_name,d.document_page,g.Genre_name,d.document_image,dtype.TypeName FROM Document d  JOIN Author a on d.author_id=a.Author_id JOIN Genre g on g.Genre_id=d.genre_id  JOIN DocumentType dtype on dtype.TypeId=d.DocumentType_id";

            DataTable result = MyExcuteReader(sql, CommandType.Text);
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
        public bool addDocument(Document doc, string authorName, string genre_name, string type_name)
        {
            string sql = @"
            SET DATEFORMAT DMY;

INSERT INTO Document (
    document_id, Publication_Year, Title, Language,
    quantity, price, author_id, document_page,
    genre_id, DocumentType_id
)
VALUES (
    @DocumentId, @PublicationYear, @Title, @Language,
    @Quantity, @Price,
    (SELECT Author_id FROM Author WHERE Author_name = @AuthorName),
    @DocumentPage,
    (SELECT Genre_id FROM Genre WHERE Genre_name = @GenreName),
    (SELECT TypeId FROM DocumentType WHERE TypeName = @TypeName)
);
        ";

            SqlParameter[] parameters = new SqlParameter[]
            {
            // 3 tham số đầu vào (dùng trong SELECT)
            new SqlParameter("@AuthorName", SqlDbType.NVarChar) { Value = authorName },
            new SqlParameter("@GenreName", SqlDbType.NVarChar) { Value = genre_name },
            new SqlParameter("@TypeName", SqlDbType.NVarChar) { Value = type_name },

            // Các giá trị để insert
            new SqlParameter("@DocumentId", SqlDbType.Int) { Value = doc.DocumentId },
            new SqlParameter("@PublicationYear", SqlDbType.Date) { Value = doc.PublicationYear},
            new SqlParameter("@Title", SqlDbType.NVarChar) { Value = doc.Title },
            new SqlParameter("@Language", SqlDbType.NVarChar) { Value = doc.Language },
            new SqlParameter("@Quantity", SqlDbType.Int) { Value = doc.Quantity },
            new SqlParameter("@Price", SqlDbType.Decimal) { Value = doc.Money },

            new SqlParameter("@DocumentPage", SqlDbType.Int) { Value = doc.DocumentPage },


            };
            return MyExcuteNonQuery(sql, CommandType.Text, parameters) > 0;
        }
        public bool UpdateDocument(Document doc, string authorName, string genreName, string typeName)
        {
            string sql = @"
    SET DATEFORMAT DMY;
    UPDATE Document
    SET
        Publication_Year = @PublicationYear,
        Title = @Title,
        Language = @Language,
        quantity = @Quantity,
        price = @Price,
        author_id = (SELECT Author_id FROM Author WHERE Author_name = @AuthorName),
        document_page = @DocumentPage,
        genre_id = (SELECT Genre_id FROM Genre WHERE Genre_name = @GenreName),
        DocumentType_id = (SELECT TypeId FROM DocumentType WHERE TypeName = @TypeName)
    WHERE document_id = @DocumentId;
    ";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@DocumentId", doc.DocumentId),
        new SqlParameter("@PublicationYear", doc.PublicationYear),
        new SqlParameter("@Title", doc.Title),
        new SqlParameter("@Language", doc.Language),
        new SqlParameter("@Quantity", doc.Quantity),
        new SqlParameter("@Price", doc.Money),
        new SqlParameter("@DocumentPage", doc.DocumentPage),
        new SqlParameter("@AuthorName", authorName),
        new SqlParameter("@GenreName", genreName),
        new SqlParameter("@TypeName", typeName)
            };

            return MyExcuteNonQuery(sql, CommandType.Text, parameters) > 0; // hoặc SqlHelper.ExecuteNonQuery
        }
        public Document searchDocument(int id)
        {
            Document d = null;
            // TODO: Thêm code lấy dữ liệu từ database nếu cần
            string sql = "SELECT document_id,Publication_Year,Title,Language,quantity,price,a.Author_name,d.document_page,g.Genre_name,d.document_image,dtype.TypeName FROM Document d  JOIN Author a on d.author_id=a.Author_id JOIN Genre g on g.Genre_id=d.genre_id  JOIN DocumentType dtype on dtype.TypeId=d.DocumentType_id WHERE d.document_id = " + id;

            DataTable result = MyExcuteReader(sql, CommandType.Text);
            foreach (DataRow dr in result.Rows)
            {
                d = new Document();
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

            }
            return d;
        }
        public int deleteDocument(int id)
        {

            string sql = " DELETE FROM Document WHERE document_id = " + id;
            return MyExcuteNonQuery(sql, CommandType.Text);
        }
        public Document GetDocumentById(int documentId)
        {
            string sql = "SELECT * FROM Document WHERE document_id = @DocumentId";
            DataTable dt = data.MyExcuteReader(sql, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@DocumentId", documentId) });

            if (dt.Rows.Count > 0)
            {
                var row = dt.Rows[0];
                return new Document
                {
                    DocumentId = documentId,
                    Title = row["Title"].ToString(),
                    Quantity = Convert.ToInt32(row["quantity"])
                };
            }

            return null;
        }
    }
}





