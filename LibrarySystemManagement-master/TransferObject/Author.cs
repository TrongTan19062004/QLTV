using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransferObject
{
    public class Author
    {
        private int authorId;
        private string authorName;
        private DateTime? authorPlaceOfBirth;
        private DateTime? authorDateCreatedAt;
        private string authorPlace;

        public int AuthorId
        {
            get { return authorId; }
            set { authorId = value; }
        }

        public string AuthorName
        {
            get { return authorName; }
            set { authorName = value; }
        }

        public DateTime? AuthorPlaceOfBirth
        {
            get { return authorPlaceOfBirth; }
            set { authorPlaceOfBirth = value; }
        }

        public DateTime? AuthorDateCreatedAt
        {
            get { return authorDateCreatedAt; }
            set { authorDateCreatedAt = value; }
        }

        public string AuthorPlace
        {
            get { return authorPlace; }
            set { authorPlace = value; }
        }
    }
}
