using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Document
    {
        private int document_id;
        private DateTime publication_Year;
        private string title;
        private string language;
        private int quantity;
        private int money;
        private string Author_name;
        private int document_page;
        private string genre_name;
        private string document_image;
        private string typeName;
       

        public int DocumentId
        {
            get { return document_id; }
            set { document_id = value; }
        }

        public DateTime PublicationYear
        {
            get { return publication_Year; }
            set { publication_Year = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Language
        {
            get { return language; }
            set { language = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Money
        {
            get { return money; }
            set { money = value; }
        }

        public string AuthorName
        {
            get { return Author_name; }
            set { Author_name = value; }
        }

        public int DocumentPage
        {
            get { return document_page; }
            set { document_page = value; }
        }

        public string GenreName
        {
            get { return genre_name; }
            set { genre_name = value; }
        }

        public string DocumentImage
        {   
            get { return document_image; }
            set { document_image = value; }
        }

        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }
        public Document()
        {

        }
        public Document(int documentId, DateTime publicationYear, string title, string language, int quantity,
                    int money, string authorName, int documentPage, string genreName,
                    string documentImage, string typeName)
        {
            this.document_id = documentId;
            this.publication_Year = publicationYear;
            this.title = title;
            this.language = language;
            this.quantity = quantity;
            this.money = money;
            this.Author_name = authorName;
            this.document_page = documentPage;
            this.genre_name = genreName;
            this.document_image = documentImage;
            this.typeName = typeName;
        }
    }
    
}
